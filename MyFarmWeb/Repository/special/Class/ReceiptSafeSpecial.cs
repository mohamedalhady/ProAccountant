using Humanizer;
using Microsoft.EntityFrameworkCore;
using Models.Models;
using MyFarmWeb.Data;
using MyFarmWeb.Repository.special.Interface;

namespace MyFarmWeb.Repository.special.Class
{
    public class ReceiptSafeSpecial : MainRepository<ReceiptSafeDetails>, IReceiptSafe
    {
        private readonly MyFarmContext _context;
        public ReceiptSafeSpecial(MyFarmContext myFarmContext) : base(myFarmContext)
        {
            _context = myFarmContext;
        }


        public IEnumerable<ReceiptSafeDetails> FilterDocumentData(string UserId, DateTime From, DateTime To,int DocumntID,  Dictionary<string, int[]> args)
        {
            var invoices = _context.ReceiptSafeDetails.AsQueryable()
                .Include(s => s.Vendor).Include(s => s.Customer).Include(s => s.ReceiptSafeHeader)
                .Include(s => s.ReceiptSafeHeader.Safe).Where(s => s.ReceiptSafeHeader.UserId == UserId);
              
      
            if (DocumntID > 0)
            {
                invoices = invoices.Where(i => i.ReceiptSafeId == DocumntID);
            }
            if (args.ContainsKey("Customers") && args["Customers"].Length > 0 )
            {
                
                invoices = invoices.Where(i => args["Customers"].Contains((int)i.CustomerId));
            }
            if (args.ContainsKey("Vendors") && args["Vendors"].Length > 0)
            {
                invoices = invoices.Where(i => args["Vendors"].Contains((int)i.VendorId));
               
            }
            if (args.ContainsKey("Safes") && args["Safes"].Length > 0)
            {
                invoices = invoices.Where(i => args["Safes"].Contains(i.ReceiptSafeHeader.SafeId));
     
            }
          
            if (From.Year > 1 && To.Year > 1)
            {
                invoices = invoices.Where(i => i.ReceiptSafeHeader.Date.Date >= From && i.ReceiptSafeHeader.Date.Date <= To);
            }
            if (From.Year > 1 && To.Year == 1)
            {
                invoices = invoices.Where(i => i.ReceiptSafeHeader.Date.Date == From);

            }
            if (From.Year == 1 && To.Year > 1)
            {
                invoices = invoices.Where(i => i.ReceiptSafeHeader.Date.Date >= From && i.ReceiptSafeHeader.Date.Date <= To);
            }
        

            var data = invoices.Select(invoice => new ReceiptSafeDetails
            {
                ReceiptSafeId = invoice.ReceiptSafeId,
                ReceiptSafeHeader = invoice.ReceiptSafeHeader,
                CustomerId = invoice.CustomerId,
                Customer = invoice.Customer,
                VendorId = invoice.VendorId,
                Vendor = invoice.Vendor,
                Amount = invoice.Amount,
                Id = invoice.Id,
                Moslsel = invoice.Moslsel,  
                Notes = invoice.Notes

            });


            return data;
        }

      

        public IEnumerable<ReceiptSafeDetails> GetDataWithMultiInclude(string UserId)
        {
            //var customers = from r in _context.ReceiptSafeDetails
            //                join t in _context.AccountTypes on r.AccountTypeId equals t.AccountTypeId
            //                join c in _context.Customers on r.AccountId equals c.CustomerId 

            throw new NotImplementedException();
        }

        public IEnumerable<ReceiptSafeDetails> GetDataWithMultiIncludeById(int InvoiceID, string UserId)
        {
            throw new NotImplementedException();
        }
    }
}
