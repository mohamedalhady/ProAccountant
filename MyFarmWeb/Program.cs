using ElectronNET.API;
using ElectronNET.API.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Models.Models;
using MyFarmWeb.Components;
using MyFarmWeb.Components.Account;
using MyFarmWeb.Data;
using MyFarmWeb.Repository;
using MyFarmWeb.Repository.Base;
using MyFarmWeb.Repository.special.Class;
using NetcodeHub.Packages.Extensions.Clipboard;
using Radzen;
using Radzen.Blazor;
using TextCopy;




var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseElectron(args);
builder.Services.AddSignalR();
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();
//builder.Services.AddTransient(typeof(IUnitOfWork<>),typeof(MainRepository<>));
builder.Services.AddTransient<IUnitOfWork,UnitOfWork>();
builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();
//Service.Encrypt("Server=.\\MSSQLSERVER2022;Database=MyFarm2;user=sa;pwd=0185354849;TrustServerCertificate=true;","hoor");

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
//var conDencerypt = Service.Decrypt(connectionString, "hoor");
builder.Services.AddDbContext<MyFarmContext>(options =>
{
        options.UseSqlServer(connectionString);
       

},ServiceLifetime.Transient);
    

builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<MyFarmContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();
builder.Services.AddSingleton<IService, JSService>();
builder.Services.AddRadzenComponents();
builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<Service>();
builder.Services.AddTransient<_Year>();
builder.Services.AddTransient<FarmType>();
builder.Services.AddTransient<Farm>();
builder.Services.AddTransient<NewFarm>();
builder.Services.AddTransient<ItemGroup>();
builder.Services.AddTransient<Item>();
builder.Services.AddTransient<VendorGroup>();
builder.Services.AddTransient<Vendor>();
builder.Services.AddTransient<CustomerGroup>();
builder.Services.AddTransient<Customer>();
builder.Services.AddTransient<Store>();
builder.Services.AddTransient<Unit>();
builder.Services.AddTransient<Expense>();
builder.Services.AddTransient<ExpenseGroup>();
builder.Services.AddTransient<Income>();
builder.Services.AddTransient<IncomeGroup>();
builder.Services.AddTransient<PurchaseInvoiceDetails>();
builder.Services.AddTransient<PurchaseInvoiceHeader>();
builder.Services.AddTransient<PurchaseReverseDetails>();
builder.Services.AddTransient<PurchaseReverseHeader>();
builder.Services.AddTransient<VendorTransaction>();
builder.Services.AddTransient<CustomerTransaction>();
builder.Services.AddTransient<SetDataGridSetting>();
builder.Services.AddScoped<DialogService>();
builder.Services.AddTransient<DataGridSetting>();
builder.Services.AddTransient<SalesInvoiceHeader>();
builder.Services.AddTransient<DataGridColumnsFrozen>();
builder.Services.AddTransient<SalesReverseHeader>();
builder.Services.AddTransient<Safe>();
builder.Services.AddTransient<Bank>();
builder.Services.AddTransient<ReceiptSafeHeader>();
builder.Services.AddTransient<ReceiptSafeDetails>();
builder.Services.AddTransient<ReceiptBankHeader>();
builder.Services.AddTransient<ReceiptBankDetails>();
builder.Services.AddTransient<PaymentSafeHeader>();
builder.Services.AddTransient<PaymentSafeDetails>();
builder.Services.AddTransient<PaymentBankHeader>();
builder.Services.AddTransient<PaymentBankDetails>();
builder.Services.AddTransient<SafeTransaction>();
builder.Services.AddTransient<BankTransaction>();
builder.Services.AddTransient<SupplyDetails>();
builder.Services.AddTransient<SupplyHeader>();
builder.Services.AddTransient<ExchangeDetails>();
builder.Services.AddTransient<ExchangeHeader>();
builder.Services.AddTransient<ItemOpeningBalanceHeader>();
builder.Services.AddTransient<CustomerOpeningBalanceHeader>();
builder.Services.AddTransient<VendorOpeningBalanceHeader>();
builder.Services.AddTransient<BankOpeningBalanceHeader>();
builder.Services.AddTransient<SafeOpeningBalanceHeader>();
builder.Services.AddSingleton<LayoutState>();
builder.Services.AddSingleton<List<Models.Models.MenuItem> >();



//builder.Services.AddHostedService<ServerTimeNotifier>();
builder.Services.AddCors();
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<MyFarmContext>();
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
    db.Database.Migrate();
    await SeedDataAsync(userManager);
    var year = db._Years.Any(y => y.Year == 1);
    if (!year)
    {
        db._Years.Add(new _Year
        {
           
            
            YearName = DateTime.Now.Year,
            From = DateTime.Now,
            To = DateTime.Now.AddYears(1),
            UserId = "1",
            Status = false
        });
        db.SaveChanges();

    }
   
    // Seed the database with initial data if necessary
    // await MyFarmContextSeed.SeedAsync(dbContext);
}
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyMethod());
app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<MyFarmWeb.Components.App>()
    .AddInteractiveServerRenderMode();

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();
app.MapHub<NotificationHub>("/chathub");

//ÅÖÇÝÉ Electron.NET Bootstrap åäÇ
if (HybridSupport.IsElectronActive)
{
    //  íÓÌá åÐÇ ÇáÅÌÑÇÁ áíÊã ÊäÝíÐå ÈÚÏ ÈÏÁ ÊÔÛíá ÎÇÏã ASP.NET Core
    app.Lifetime.ApplicationStarted.Register(async () =>
    {
        var options = new BrowserWindowOptions
        {
            Width = 1200,
            Height = 800,
            Show = false,
            Title = "My Blazor Electron App",
            AutoHideMenuBar = true, // ÅÎÝÇÁ ÔÑíØ ÇáÞæÇÆã
            DarkTheme = true, // ÊÝÚíá ÇáæÖÚ ÇáÏÇßä
            Center= true, // ãÑßÒ ÇáäÇÝÐÉ Úáì ÇáÔÇÔÉ
            
        };

        var browserWindow = await Electron.WindowManager.CreateWindowAsync(options);

        //  ÅÙåÇÑ ÇáäÇÝÐÉ ÈãÌÑÏ Ãä Êßæä ÌÇåÒÉ ááÚÑÖ(ÊÌäÈÇð ááæãíÖ ÇáÃÈíÖ
        browserWindow.OnReadyToShow += () => browserWindow.Show();
    });
}



app.Run();


static async Task SeedDataAsync(UserManager<ApplicationUser> userManager)
{
   

    // Create admin user
   
    if (await userManager.FindByEmailAsync("admin@erp.com") == null)
    {
        var adminUser = new ApplicationUser
        {
            Id = "1",
            UserName = "admin",
            Email = "admin@erp.com",
            GovernorateId = 1, // Assuming you have a Governorate with Id 1
            EmailConfirmed = true,

        };

        var result = await userManager.CreateAsync(adminUser, "Admin123!");
        
    }
}