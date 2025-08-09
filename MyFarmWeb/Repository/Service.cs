using ElectronNET.API.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using MyFarmWeb.Data;
using MyFarmWeb.Repository.Base;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace MyFarmWeb.Repository
{
    public class Service
    {
  
        private IUnitOfWork UnitOfWork { get; set; }
        private  AuthenticationStateProvider GetAuthenticationStateAsync;
        private  UserManager<ApplicationUser> UserManager;
         private     SignInManager<ApplicationUser> SignInManager;

        [Inject]
        public List<Models.Models.MenuItem> MenuItems { get; set; } 
        public Service(AuthenticationStateProvider stateProvider,UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> signInManager,IUnitOfWork unitOfWork)
        {
            GetAuthenticationStateAsync = stateProvider;
           UserManager = userManager;
            SignInManager = signInManager;
            UnitOfWork = unitOfWork;
         
        }
     
        public async Task<string> GetUserId()
        {

            string UserId = "";
            var authstate = await GetAuthenticationStateAsync.GetAuthenticationStateAsync();
            var user = authstate.User;
            if (user != null)
            {
                UserId = user.FindFirst(u => u.Type.Contains("nameidentifier"))?.Value;
            }
            return UserId;
        }
        public  async Task< List<Models.Models.MenuItem>> GetMenuItems()
        {
            var item  = await UnitOfWork.MenuItems.GetAllAsync(); 
            MenuItems = item.ToList();
            return MenuItems;
        }
        public async Task<bool>IsAuth()
        {
          
                var authstate =await GetAuthenticationStateAsync.GetAuthenticationStateAsync();
                var user = authstate.User;
                if (user != null )
                {
                    return user.Identity.IsAuthenticated;
                }
                return false;
           
        }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public async Task signOut()
        {
          await  SignInManager.SignOutAsync();
         
        }

        public static string Decrypt(string cipherText, string key)
        {
            string EncryptionKey = key;
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                       cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

        public static string Encrypt(string clearText, string key)
        {
            string EncryptionKey = key;
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

    }
}
