using Microsoft.EntityFrameworkCore;
using Models.Models;
using MyFarmWeb.Data;
using MyFarmWeb.Repository.special.Interface;

namespace MyFarmWeb.Repository.special.Class
{
    public class PaymentSafeSpecial : MainRepository<PaymentSafeDetails>, IPaymentSafe
    {
        private readonly MyFarmContext _context;
        public PaymentSafeSpecial(MyFarmContext myFarmContext) : base(myFarmContext)
        {
            _context = myFarmContext;
        }

        public IEnumerable<PaymentSafeDetails> FilterDocumentData(string UserId, DateTime From, DateTime To, int DocumntID, Dictionary<string, int[]> args)
        {
            var invoices = _context.PaymentSafeDetails.AsQueryable()
               .Include(s => s.Vendor).Include(s => s.Customer).Include(s => s.PaymentSafeHeader)
               .Include(s => s.PaymentSafeHeader.Safe).Where(s => s.PaymentSafeHeader.UserId == UserId);


            if (DocumntID > 0)
            {
                invoices = invoices.Where(i => i.PaymentSafeId == DocumntID);
            }
            if (args.ContainsKey("Customers") && args["Customers"].Length > 0)
            {

                invoices = invoices.Where(i => args["Customers"].Contains((int)i.CustomerId));
            }
            if (args.ContainsKey("Vendors") && args["Vendors"].Length > 0)
            {
                invoices = invoices.Where(i => args["Vendors"].Contains((int)i.VendorId));

            }
            if (args.ContainsKey("Safes") && args["Safes"].Length > 0)
            {
                invoices = invoices.Where(i => args["Safes"].Contains(i.PaymentSafeHeader.SafeId));

            }
            //if (args.ContainsKey("Farms") && args["Farms"].Length > 0)
            //{
            //    invoices = invoices.Where(i => args["Farms"].Contains(i.PaymentSafeHeader.FarmId));

            //}
            if (From.Year > 1 && To.Year > 1)
            {
                invoices = invoices.Where(i => i.PaymentSafeHeader.Date.Date >= From && i.PaymentSafeHeader.Date.Date <= To);
            }
            if (From.Year > 1 && To.Year == 1)
            {
                invoices = invoices.Where(i => i.PaymentSafeHeader.Date.Date == From);

            }
            if (From.Year == 1 && To.Year > 1)
            {
                invoices = invoices.Where(i => i.PaymentSafeHeader.Date.Date >= From && i.PaymentSafeHeader.Date.Date <= To);
            }


            var data = invoices.Select(invoice => new PaymentSafeDetails
            {
                PaymentSafeId = invoice.PaymentSafeId,
                PaymentSafeHeader = invoice.PaymentSafeHeader,
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

        public IEnumerable<PaymentSafeDetails> GetDataWithMultiInclude(string UserId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PaymentSafeDetails> GetDataWithMultiIncludeById(int InvoiceID, string UserId)
        {
            throw new NotImplementedException();
        }
    }
}
