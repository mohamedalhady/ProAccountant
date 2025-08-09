using Microsoft.EntityFrameworkCore;
using Models.Models;
using MyFarmWeb.Data;
using MyFarmWeb.Repository.special.Interface;

namespace MyFarmWeb.Repository.special.Class
{
    public class BankTransactionsSpecial : MainRepository<BankTransaction>, IBankTransactions
    {
        private readonly MyFarmContext _context;
        public BankTransactionsSpecial(MyFarmContext myFarmContext) : base(myFarmContext)
        {
            _context = myFarmContext;
        }

        public IEnumerable<BankTransaction> FilterDocumentData(string UserId, DateTime From, DateTime To, int DocumntID, Dictionary<string, int[]> args)
        {
            var invoices = _context.BankTransactions.AsQueryable()

                .Include(s => s.Bank).Include(s => s.DocumentType).Where(s => s.UserId == UserId);
            

            if (DocumntID > 0)
            {
                invoices = invoices.Where(i => i.DocumentId == DocumntID);
            }

            if (args.ContainsKey("Banks") && args["Banks"].Length > 0)
            {
                invoices = invoices.Where(i => args["Banks"].Contains(i.BankId));

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


            var data = invoices.Select(invoice => new BankTransaction
            {
                TransactionDate = invoice.TransactionDate,
                DocumentId = invoice.DocumentId,
                CreateDate = invoice.CreateDate,
                DocumentType = invoice.DocumentType,
                DocumentTypeId = invoice.DocumentTypeId,
                Id = invoice.Id,
                BankId = invoice.BankId,
                Bank = invoice.Bank,
                Value = invoice.Value


            });


            return data;
        }

        public IEnumerable<BankTransaction> GetDataWithMultiInclude(string UserId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BankTransaction> GetDataWithMultiIncludeById(int InvoiceID, string UserId)
        {
            throw new NotImplementedException();
        }
    }
}
