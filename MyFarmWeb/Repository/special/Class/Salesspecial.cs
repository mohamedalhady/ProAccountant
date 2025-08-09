using Microsoft.EntityFrameworkCore;
using Models.Models;
using MyFarmWeb.Data;
using MyFarmWeb.Repository.special.Interface;
using static MyFarmWeb.Components.Pages.Test;

namespace MyFarmWeb.Repository.special.Class
{
    public class Salesspecial : MainRepository<SalesInvoiceDetails>, ISales
    {
        private readonly MyFarmContext _context;
        public Salesspecial(MyFarmContext myFarmContext) : base(myFarmContext)
        {
            _context = myFarmContext;
        }




        public IEnumerable<SalesInvoiceDetails> GetDataWithMultiInclude(string UserId)
        {
            var invoices = _context.SalesInvoiceDetails.Include(c => c.Item)
              .Include(c => c.Unit).Include(c => c.Store)
              .Include(c => c.SalesInvoiceHeader).ThenInclude(s => s.Customer).ToList();

            invoices = invoices.Where(c => c.SalesInvoiceHeader?.UserId == UserId).ToList();
            return invoices;
        }

        public IEnumerable<InvoiceForReport> GetDocumentDataForReport(string UserId)
        {
            IQueryable<InvoiceForReport> data;
            data = from d in _context.SalesInvoiceDetails
                   join h in _context.SalesInvoiceHeader on d.SalesInvoiceId equals h.SalesInvoiceId
            where h.UserId == UserId
                   join v in _context.Customers on h.CustomerId equals v.CustomerId
                   join i in _context.Items on d.ItemId equals i.ItemId
                   join u in _context.Units on d.UnitId equals u.UnitId
                   join s in _context.Stores on d.StoreId equals s.StoreId

                   select new InvoiceForReport()
                   {

                       InvoiceId = h.SalesInvoiceId,
                       Id = d.Moslsel,
                       Date = h.SalesInvoiceDate,
                       ManId = v.CustomerId,
                       ManName = v.CustomerName,
                       ItemId = i.ItemId,
                       ItemName = i.ItemName,
                       Store = s.StoreName,
                       Unit = u.UnitName,
                       Quantity = d.Quantity,
                       Price = d.Price,
                       UnitCost= d.UnitCost,
                       TotalCost = d.TotalCost,
                       Amount = d.Amount,
                       Discount = d.ItemDiscount,
                       NetAmount = d.NetAmount,
                       Note = d.ItemNote,

                   };
            IQueryable<InvoiceForReport> data2;
            data2 = from d in _context.SalesReverseDetails
                    join h in _context.SalesReverseHeader on d.SalesInvoiceId equals h.SalesInvoiceId
            where h.UserId == UserId
                    join v in _context.Customers on h.CustomerId equals v.CustomerId
                    join i in _context.Items on d.ItemId equals i.ItemId
                    join u in _context.Units on d.UnitId equals u.UnitId
                    join s in _context.Stores on d.StoreId equals s.StoreId

                    select new InvoiceForReport()
                    {

                        InvoiceId = h.SalesInvoiceId,
                        Id = d.Moslsel,
                        Date = h.SalesInvoiceDate,
                        ManId = v.CustomerId,
                        ManName = v.CustomerName,
                        ItemId = i.ItemId,
                        ItemName = i.ItemName,
                        Store = s.StoreName,
                        Unit = u.UnitName,
                        Quantity = d.Quantity * -1,
                        Price = d.Price,
                        Amount = d.Amount * -1,
                        Discount = d.ItemDiscount * -1,
                        NetAmount = d.NetAmount * -1,
                        Note = d.ItemNote
                    };
            data.Union(data2);
            return data.ToList();
        }

        public IEnumerable<SalesInvoiceDetails> GetDataWithMultiIncludeById(int InvoiceID, string UserId)
        {
            var invoices = _context.SalesInvoiceDetails.Include(c => c.Item)
                .Include(c => c.Unit).Include(c => c.Store)
                .Include(c => c.SalesInvoiceHeader).ThenInclude(s => s.Customer).ToList();

            invoices = invoices.Where(c => c.SalesInvoiceHeader?.UserId == UserId && c.SalesInvoiceId == InvoiceID).ToList();
            return invoices;
        }

        public IEnumerable<InvoiceForReport> FilterDocumentDataForReport(int[] customerid, int[] itemsid, int[] storeid, DateTime from, DateTime to, int invoiceid,string userid)
        {
            var invoices = _context.SalesInvoiceDetails.AsQueryable().Where(s => s.SalesInvoiceHeader.UserId == userid);
            var reverse = _context.SalesReverseDetails.AsQueryable().Where(s => s.salesReverseHeader.UserId == userid);
            // Apply filters if arrays are not null or empty
            if (invoiceid > 0)
            {
                invoices = invoices.Where(i => i.SalesInvoiceId == invoiceid);
                reverse = reverse.Where(i => i.SalesInvoiceId == invoiceid);
            }
            if (customerid != null && customerid.Any())
            {
                invoices = invoices.Where(i => customerid.Contains(i.SalesInvoiceHeader.CustomerId));
                reverse = reverse.Where(i => customerid.Contains(i.salesReverseHeader.CustomerId));
            }
            if (itemsid != null && itemsid.Any())
            {
                invoices = invoices.Where(i => itemsid.Contains(i.ItemId));
                reverse = reverse.Where(i => itemsid.Contains(i.ItemId));
            }
            if (storeid != null && storeid.Any())
            {
                invoices = invoices.Where(i => storeid.Contains(i.StoreId));
                reverse = reverse.Where(i => storeid.Contains(i.StoreId));
            }
            if (from.Year > 1 && to.Year > 1)
            {
                invoices = invoices.Where(i => i.SalesInvoiceHeader.SalesInvoiceDate.Date >= from && i.SalesInvoiceHeader.SalesInvoiceDate.Date <= to);
                reverse = reverse.Where(i => i.salesReverseHeader.SalesInvoiceDate.Date >= from && i.salesReverseHeader.SalesInvoiceDate.Date <= to);
            }
            if (from.Year > 1 && to.Year == 1)
            {
                invoices = invoices.Where(i => i.SalesInvoiceHeader.SalesInvoiceDate.Date == from);
                reverse = reverse.Where(i => i.salesReverseHeader.SalesInvoiceDate.Date == from);

            }
            if (from.Year == 1 && to.Year > 1)
            {
                invoices = invoices.Where(i => i.SalesInvoiceHeader.SalesInvoiceDate.Date >= from && i.SalesInvoiceHeader.SalesInvoiceDate.Date <= to);
                reverse = reverse.Where(i => i.salesReverseHeader.SalesInvoiceDate.Date >= from && i.salesReverseHeader.SalesInvoiceDate.Date <= to);
            }
            // Project filtered results into InvoiceForReport objects

            var data1 = invoices.Select(invoice => new InvoiceForReport
            {
                InvoiceId = invoice.SalesInvoiceId,
                ManName = invoice.SalesInvoiceHeader.Customer.CustomerName,
                ItemName = invoice.Item.ItemName,
                ItemId = invoice.ItemId,
                Date = invoice.SalesInvoiceHeader.SalesInvoiceDate,
                Store = invoice.Store.StoreName,
                Amount = invoice.Amount,
                Discount = invoice.ItemDiscount,
                Id = invoice.Moslsel,
                ManId = invoice.SalesInvoiceHeader.CustomerId,
                NetAmount = invoice.NetAmount,
                Note = invoice.ItemNote,
                Price = invoice.Price,
                UnitCost= invoice.UnitCost,
                TotalCost = invoice.TotalCost,
                Quantity = invoice.Quantity,
                Unit = invoice.Unit.UnitName,
                DocumentType = "فاتورة مبيعات",
                DocumentTypeID = 2


            });
            var data2 = reverse.Select(invoice => new InvoiceForReport
            {
                InvoiceId = invoice.SalesInvoiceId,
                ManName = invoice.salesReverseHeader.Customer.CustomerName,
                ItemName = invoice.Item.ItemName,
                ItemId = invoice.ItemId,
                Date = invoice.salesReverseHeader.SalesInvoiceDate,
                Store = invoice.Store.StoreName,
                Amount = invoice.Amount * -1 ,
                Discount = invoice.ItemDiscount * -1,
                Id = invoice.Moslsel,
                ManId = invoice.salesReverseHeader.CustomerId,
                NetAmount = invoice.NetAmount  * -1 ,
                Note = invoice.ItemNote,
                Price = invoice.Price,
                UnitCost = invoice.UnitCost * -1 ,
                TotalCost = invoice.TotalCost * -1,
                Quantity = invoice.Quantity * -1,
                Unit = invoice.Unit.UnitName,
                DocumentType = "مرتجع مبيعات",
                DocumentTypeID = 10
            });

            return data1.Union(data2).ToList();
        }

        public IEnumerable<AccountStatementReport> CreateAccountStatement(int[] customersid, DateTime from, DateTime to, string userid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SalesInvoiceDetails> FilterDocumentData(string UserId, DateTime From, DateTime To, int DocumntID, Dictionary<string, int[]>   args)
        {
            throw new NotImplementedException();
        }
        static decimal balance { get; set; } = 0;
        public IEnumerable<AccountStatementReport> CreateAccountStatement(int customerid, DateTime from, DateTime to)
        {
            balance = 0;
            var openingBalance = contextdb.CustomerTransactions.AsQueryable().Where(s => s.TransactionDate < from && s.CustomerId == customerid).GroupBy(s => new { s.CustomerId })
                 .Select(g => new AccountStatementReport
                 {
                     TransactionDate = from,
                     DocumentId = 0,
                     DocumentTypeId = 0,
                     DocumentTypeName = "رصيد افتتاحي",
                     ManId = customerid,
                     ManName = contextdb.Customers.FirstOrDefault(v => v.CustomerId == customerid).CustomerName,
                     Credit = g.Sum(s => s.Value) > 0 ? g.Sum(s => s.Value) : 0,
                     Debit = g.Sum(s => s.Value) < 0 ? g.Sum(s => s.Value) * -1 : 0,
                     Note = "رصيد افتتاحي",
                     Balance = GetBalance(g.Sum(s => s.Value)),
                 }).ToList();


            var Debit = contextdb.CustomerTransactions.AsQueryable().Where
                (s => s.CustomerId == customerid && s.TransactionDate.Date >= from && s.TransactionDate.Date <= to && s.Value < 0).OrderBy(s => s.TransactionDate)
                .Select(s => new AccountStatementReport
                {
                    TransactionDate = s.TransactionDate,
                    DocumentId = s.DocumentId,
                    DocumentTypeId = s.DocumentTypeId,
                    DocumentTypeName = contextdb.DocumentTypes.FirstOrDefault(d => d.DocumentTypeId == s.DocumentTypeId).DocumentTypeName,
                    ManId = s.CustomerId,
                    ManName = contextdb.Customers.FirstOrDefault(v => v.CustomerId == s.CustomerId).CustomerName,
                    Credit = 0,
                    Debit = s.Value * -1, // Assuming Debit is negative value
                    Note = s.Note,
                    Balance = GetBalance(s.Value)
                }).ToList();

            var Credit = contextdb.CustomerTransactions.AsQueryable().Where
               (s => s.CustomerId == customerid && s.TransactionDate.Date >= from && s.TransactionDate.Date <= to && s.Value > 0)
               .Select(s => new AccountStatementReport
               {
                   TransactionDate = s.TransactionDate,
                   DocumentId = s.DocumentId,
                   DocumentTypeId = s.DocumentTypeId,
                   DocumentTypeName = contextdb.DocumentTypes.FirstOrDefault(d => d.DocumentTypeId == s.DocumentTypeId).DocumentTypeName,
                   ManId = s.CustomerId,
                   Credit = s.Value,
                   Debit = 0, // Assuming Debit is negative value
                   ManName = contextdb.Customers.FirstOrDefault(v => v.CustomerId == s.CustomerId).CustomerName,
                   Note = s.Note,
                   Balance = GetBalance(s.Value)
               }).ToList();
            return openingBalance.Union(Debit).Union(Credit).OrderBy(s => s.TransactionDate).ToList();
        }
        static decimal GetBalance(decimal value)
        {

            balance += value;
            return balance;


        }
    }
}
