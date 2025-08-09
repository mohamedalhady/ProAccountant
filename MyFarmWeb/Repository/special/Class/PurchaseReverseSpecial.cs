using Microsoft.EntityFrameworkCore;
using Models.Models;
using MyFarmWeb.Data;
using MyFarmWeb.Repository.special.Interface;

namespace MyFarmWeb.Repository.special.Class
{
    public class PurchaseReverseSpecial : MainRepository<PurchaseReverseDetails>, IPurchaseReverse
    {
        private readonly MyFarmContext _context;
        public PurchaseReverseSpecial(MyFarmContext myFarmContext) : base(myFarmContext)
        {
            _context = myFarmContext;
        }

        public IEnumerable<PurchaseReverseDetails> FilterDocumentData(string UserId, DateTime From, DateTime To, int DocumntID, Dictionary<string, int[]> args)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PurchaseReverseDetails> GetDataWithMultiInclude(string UserId)
        {
            var invoices = _context.PurchaseReverseDetails.Include(c => c.Item)
                 .Include(c => c.Unit).Include(c => c.Store)
                 .Include(c => c.purchaseReverseHeader).ThenInclude(s => s.Vendor).ToList();

            invoices = invoices.Where(c => c.purchaseReverseHeader?.UserId == UserId).ToList();
            return invoices;
        }

  

        public IEnumerable<PurchaseReverseDetails> GetDataWithMultiIncludeById(int InvoiceID, string UserId)
        {
            var invoices = _context.PurchaseReverseDetails.Include(c => c.Item)
            .Include(c => c.Unit).Include(c => c.Store)
            .Include(c => c.purchaseReverseHeader).ThenInclude(s => s.Vendor).ToList();

            invoices = invoices.Where(c => c.purchaseReverseHeader?.UserId == UserId && c.PurchaseInvoiceId == InvoiceID).ToList();
            return invoices;
        }

    }
}
