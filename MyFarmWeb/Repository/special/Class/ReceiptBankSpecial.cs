using Microsoft.EntityFrameworkCore;
using Models.Models;
using MyFarmWeb.Data;
using MyFarmWeb.Repository.special.Interface;

namespace MyFarmWeb.Repository.special.Class
{
    public class ReceiptBankSpecial : MainRepository<ReceiptBankDetails>, IReceiptBank
    {

        private readonly MyFarmContext _context;
        public ReceiptBankSpecial(MyFarmContext myFarmContext) : base(myFarmContext)
        {
            _context = myFarmContext;
        }

        public IEnumerable<ReceiptBankDetails> FilterDocumentData(string UserId, DateTime From, DateTime To, int DocumntID, Dictionary<string, int[]> args)
        {
            var invoices = _context.ReceiptBankDetails.AsQueryable()
                 .Include(s => s.Vendor).Include(s => s.Customer).Include(s => s.ReceiptBankHeader)
                 .Include(s => s.ReceiptBankHeader.Bank).Where(s => s.ReceiptBankHeader.UserId == UserId);


            if (DocumntID > 0)
            {
                invoices = invoices.Where(i => i.ReceiptBankId == DocumntID);
            }
            if (args.ContainsKey("Customers") && args["Customers"].Length > 0)
            {

                invoices = invoices.Where(i => args["Customers"].Contains((int)i.CustomerId));
            }
            if (args.ContainsKey("Vendors") && args["Vendors"].Length > 0)
            {
                invoices = invoices.Where(i => args["Vendors"].Contains((int)i.VendorId));

            }
            if (args.ContainsKey("Banks") && args["Banks"].Length > 0)
            {
                invoices = invoices.Where(i => args["Banks"].Contains(i.ReceiptBankHeader.BankId));

            }
          
            if (From.Year > 1 && To.Year > 1)
            {
                invoices = invoices.Where(i => i.ReceiptBankHeader.Date.Date >= From && i.ReceiptBankHeader.Date.Date <= To);
            }
            if (From.Year > 1 && To.Year == 1)
            {
                invoices = invoices.Where(i => i.ReceiptBankHeader.Date.Date == From);

            }
            if (From.Year == 1 && To.Year > 1)
            {
                invoices = invoices.Where(i => i.ReceiptBankHeader.Date.Date >= From && i.ReceiptBankHeader.Date.Date <= To);
            }


            var data = invoices.Select(invoice => new ReceiptBankDetails
            {
                ReceiptBankId = invoice.ReceiptBankId,
                ReceiptBankHeader = invoice.ReceiptBankHeader,
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

        public IEnumerable<ReceiptBankDetails> GetDataWithMultiInclude(string UserId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReceiptBankDetails> GetDataWithMultiIncludeById(int InvoiceID, string UserId)
        {
            throw new NotImplementedException();
        }
    }
}
