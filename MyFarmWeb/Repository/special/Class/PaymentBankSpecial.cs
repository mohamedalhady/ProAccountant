using Microsoft.EntityFrameworkCore;
using Models.Models;
using MyFarmWeb.Data;
using MyFarmWeb.Repository.special.Interface;

namespace MyFarmWeb.Repository.special.Class
{
   
    public class PaymentBankSpecial : MainRepository<PaymentBankDetails>, IPaymentBank
    {
        private readonly MyFarmContext _context;
        public PaymentBankSpecial(MyFarmContext myFarmContext) : base(myFarmContext)
        {
            _context = myFarmContext;
        }

        public IEnumerable<PaymentBankDetails> FilterDocumentData(string UserId, DateTime From, DateTime To, int DocumntID, Dictionary<string, int[]> args)
        {
            var invoices = _context.PaymentBankDetails.AsQueryable()
              .Include(s => s.Vendor).Include(s => s.Customer).Include(s => s.PaymentBankHeader)
              .Include(s => s.PaymentBankHeader.Bank).Where(s => s.PaymentBankHeader.UserId == UserId);


            if (DocumntID > 0)
            {
                invoices = invoices.Where(i => i.PaymentBankId == DocumntID);
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
                invoices = invoices.Where(i => args["Banks"].Contains(i.PaymentBankHeader.BankId));

            }
            //if (args.ContainsKey("Farms") && args["Farms"].Length > 0)
            //{
            //    invoices = invoices.Where(i => args["Farms"].Contains(i.PaymentBankHeader.FarmId));

            //}
            if (From.Year > 1 && To.Year > 1)
            {
                invoices = invoices.Where(i => i.PaymentBankHeader.Date.Date >= From && i.PaymentBankHeader.Date.Date <= To);
            }
            if (From.Year > 1 && To.Year == 1)
            {
                invoices = invoices.Where(i => i.PaymentBankHeader.Date.Date == From);

            }
            if (From.Year == 1 && To.Year > 1)
            {
                invoices = invoices.Where(i => i.PaymentBankHeader.Date.Date >= From && i.PaymentBankHeader.Date.Date <= To);
            }


            var data = invoices.Select(invoice => new PaymentBankDetails
            {
                PaymentBankId = invoice.PaymentBankId,
                PaymentBankHeader = invoice.PaymentBankHeader,
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

        public IEnumerable<PaymentBankDetails> GetDataWithMultiInclude(string UserId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PaymentBankDetails> GetDataWithMultiIncludeById(int InvoiceID, string UserId)
        {
            throw new NotImplementedException();
        }
    }
}
