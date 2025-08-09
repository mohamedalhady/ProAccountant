using Microsoft.EntityFrameworkCore;
using Models.Models;
using MyFarmWeb.Data;
using MyFarmWeb.Repository.special.Interface;

namespace MyFarmWeb.Repository.special.Class
{
    public class SafeTransactionsSpecial : MainRepository<SafeTransaction>, ISafeTransactions
    {
        private readonly MyFarmContext _context;
        public SafeTransactionsSpecial(MyFarmContext myFarmContext) : base(myFarmContext)
        {
            _context = myFarmContext;
        }

        public IEnumerable<SafeTransaction> FilterDocumentData(string UserId, DateTime From, DateTime To, int DocumntID, Dictionary<string, int[]> args)
        {
            var invoices = _context.SafeTransactions.AsQueryable()
                
                .Include(s => s.Safe).Include(s => s.DocumentType).Where(s => s.UserId == UserId);


            if (DocumntID > 0)
            {
                invoices = invoices.Where(i => i.DocumentId == DocumntID);
            }
          
            if (args.ContainsKey("Safes") && args["Safes"].Length > 0)
            {
                invoices = invoices.Where(i => args["Safes"].Contains(i.SafeId));

            }
        
            if (From.Year > 1 && To.Year > 1)
            {
                invoices = invoices.Where(i => i.TransactionDate.Date >= From && i.TransactionDate.Date <= To);
            }
            if (From.Year > 1 && To.Year == 1)
            {
                invoices = invoices.Where(i => i.TransactionDate.Date == From);

            }
            if (From.Year == 1 && To.Year > 1)
            {
                invoices = invoices.Where(i => i.TransactionDate.Date >= From && i.TransactionDate.Date <= To);
            }


            var data = invoices.Select(invoice => new SafeTransaction
            {
               TransactionDate = invoice.TransactionDate,
               DocumentId = invoice.DocumentId,
               CreateDate = invoice.CreateDate,
               DocumentType = invoice.DocumentType,
               DocumentTypeId = invoice.DocumentTypeId,
               Id = invoice.Id,
               SafeId = invoice.SafeId,
               Safe = invoice.Safe,
               Value = invoice.Value
               

            });


            return data;
        }

        public IEnumerable<SafeTransaction> GetDataWithMultiInclude(string UserId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SafeTransaction> GetDataWithMultiIncludeById(int InvoiceID, string UserId)
        {
            throw new NotImplementedException();
        }
    }
}
