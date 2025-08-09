using Microsoft.EntityFrameworkCore;
using Models.Models;
using MyFarmWeb.Data;
using MyFarmWeb.Repository.special.Interface;

namespace MyFarmWeb.Repository.special.Class
{
    public class SalesReverseSpecial : MainRepository<SalesReverseDetails>, ISalesReverse
    {
        private readonly MyFarmContext _context;
        public SalesReverseSpecial(MyFarmContext myFarmContext) : base(myFarmContext)
        {
            _context = myFarmContext;
        }

        public IEnumerable<SalesReverseDetails> FilterDocumentData(string UserId, DateTime From, DateTime To, int DocumntID, Dictionary<string, int[]> args)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SalesReverseDetails> GetDataWithMultiInclude(string UserId)
        {
            var invoices = _context.SalesReverseDetails.Include(c => c.Item)
              .Include(c => c.Unit).Include(c => c.Store)
              .Include(c => c.salesReverseHeader).ThenInclude(s => s.Customer).ToList();

            invoices = invoices.Where(c => c.salesReverseHeader?.UserId == UserId).ToList();
            return invoices;

        }

   
        public IEnumerable<SalesReverseDetails> GetDataWithMultiIncludeById(int InvoiceID, string UserId)
        {
            var invoices = _context.SalesReverseDetails.Include(c => c.Item)
             .Include(c => c.Unit).Include(c => c.Store)
             .Include(c => c.salesReverseHeader).ThenInclude(s => s.Customer).ToList();

            invoices = invoices.Where(c => c.salesReverseHeader?.UserId == UserId && c.SalesInvoiceId == InvoiceID).ToList();
            return invoices;

        }

  
    }
}
