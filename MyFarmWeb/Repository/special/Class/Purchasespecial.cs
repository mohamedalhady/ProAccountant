using Microsoft.EntityFrameworkCore;
using Models.Models;
using MyFarmWeb.Components.Pages.Purchase;
using MyFarmWeb.Data;
using MyFarmWeb.Repository.Enums;
using MyFarmWeb.Repository.special.Interface;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace MyFarmWeb.Repository.special.Class
{
    public class Purchasespecial : MainRepository<PurchaseInvoiceDetails>, IPurchase
    {
        private readonly MyFarmContext _context;
        public Purchasespecial(MyFarmContext myFarmContext) : base(myFarmContext)
        {
            _context = myFarmContext;
        }

        public IEnumerable<InvoiceForReport> GetDocumentDataForReport(string UserId)
        {


            IQueryable<InvoiceForReport> data;
            data = from d in _context.PurchaseInvoiceDetails
                   join h in _context.PurchaseInvoiceHeader on d.PurchaseInvoiceId equals h.PurchaseInvoiceId
                   where h.UserId == UserId
                   join v in _context.Vendors on h.VendorId equals v.VendorId
                   join i in _context.Items on d.ItemId equals i.ItemId
                   join u in _context.Units on d.UnitId equals u.UnitId
                   join s in _context.Stores on d.StoreId equals s.StoreId

                   select new InvoiceForReport()
                   {

                       InvoiceId = h.PurchaseInvoiceId,
                       Id = d.Moslsel,
                       Date = h.PurchaseInvoiceDate,
                       ManId = v.VendorId,
                       ManName = v.VendorName,
                       ItemId = i.ItemId,
                       ItemName = i.ItemName,
                       Store = s.StoreName,
                       Unit = u.UnitName,
                       Quantity = d.Quantity,
                       Price = d.Price,
                       Amount = d.Amount,
                       Discount = d.ItemDiscount,
                       NetAmount = d.NetAmount,
                       Note = d.ItemNote,

                   };
            IQueryable<InvoiceForReport> data2;
            data2 = from d in _context.PurchaseReverseDetails
                    join h in _context.PurchaseReverseHeader on d.PurchaseInvoiceId equals h.PurchaseInvoiceId
                    where h.UserId == UserId
                    join v in _context.Vendors on h.VendorId equals v.VendorId
                    join i in _context.Items on d.ItemId equals i.ItemId
                    join u in _context.Units on d.UnitId equals u.UnitId
                    join s in _context.Stores on d.StoreId equals s.StoreId

                    select new InvoiceForReport()
                    {

                        InvoiceId = h.PurchaseInvoiceId,
                        Id = d.Moslsel,
                        Date = h.PurchaseInvoiceDate,
                        ManId = v.VendorId,
                        ManName = v.VendorName,
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
        public IEnumerable<PurchaseInvoiceDetails> GetDataWithMultiInclude(string UserId)
        {
            var invoices = _context.PurchaseInvoiceDetails.Include(c => c.Item)
               .Include(c => c.Unit).Include(c => c.Store)
               .Include(c => c.purchaseInvoiceHeader).ThenInclude(s => s.Vendor).ToList();

            invoices = invoices.Where(c => c.purchaseInvoiceHeader?.UserId == UserId).ToList();
            return invoices;


        }

        public IEnumerable<PurchaseInvoiceDetails> GetDataWithMultiIncludeById(int InvoiceID, string UserId)
        {
            var invoices = _context.PurchaseInvoiceDetails.Include(c => c.Item)
                .Include(c => c.Unit).Include(c => c.Store)
                .Include(c => c.purchaseInvoiceHeader).ThenInclude(s => s.Vendor).ToList();

            invoices = invoices.Where(c => c.purchaseInvoiceHeader?.UserId == UserId && c.PurchaseInvoiceId == InvoiceID).ToList();
            return invoices;


        }

        public IEnumerable<InvoiceForReport> FilterDocumentDataForReport(int[] vendorsid, int[] itemsid, int[] storeid, DateTime from, DateTime to, int invoiceid, string userid)
        {
            var invoices = _context.PurchaseInvoiceDetails.AsQueryable().Where(s => s.purchaseInvoiceHeader.UserId == userid);
            var reverse = _context.PurchaseReverseDetails.AsQueryable().Where(s => s.purchaseReverseHeader.UserId == userid);
            // Apply filters if arrays are not null or empty
            if (invoiceid > 0)
            {

                invoices = invoices.Where(i => i.PurchaseInvoiceId == invoiceid);
                reverse = reverse.Where(i => i.PurchaseInvoiceId == invoiceid);
            }
            if (vendorsid != null && vendorsid.Any())
            {

                invoices = invoices.Where(i => vendorsid.Contains(i.purchaseInvoiceHeader.VendorId));
                reverse = reverse.Where(i => vendorsid.Contains(i.purchaseReverseHeader.VendorId));
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
                invoices = invoices.Where(i => i.purchaseInvoiceHeader.PurchaseInvoiceDate.Date >= from && i.purchaseInvoiceHeader.PurchaseInvoiceDate.Date <= to);
                reverse = reverse.Where(i => i.purchaseReverseHeader.PurchaseInvoiceDate.Date >= from && i.purchaseReverseHeader.PurchaseInvoiceDate.Date <= to);
            }
            if (from.Year > 1 && to.Year == 1)
            {
                invoices = invoices.Where(i => i.purchaseInvoiceHeader.PurchaseInvoiceDate.Date == from);
                reverse = reverse.Where(i => i.purchaseReverseHeader.PurchaseInvoiceDate.Date == from);

            }
            if (from.Year == 1 && to.Year > 1)
            {
                invoices = invoices.Where(i => i.purchaseInvoiceHeader.PurchaseInvoiceDate.Date >= from && i.purchaseInvoiceHeader.PurchaseInvoiceDate.Date <= to);
                reverse = reverse.Where(i => i.purchaseReverseHeader.PurchaseInvoiceDate.Date >= from && i.purchaseReverseHeader.PurchaseInvoiceDate.Date <= to);
            }
            // Project filtered results into InvoiceForReport objects


            var data1 = invoices.Select(invoice => new InvoiceForReport
            {
                InvoiceId = invoice.PurchaseInvoiceId,
                ManName = invoice.purchaseInvoiceHeader.Vendor.VendorName,
                ItemName = invoice.Item.ItemName,
                ItemId = invoice.ItemId,
                Date = invoice.purchaseInvoiceHeader.PurchaseInvoiceDate,
                Store = invoice.Store.StoreName,
                Amount = invoice.Amount,
                Discount = invoice.ItemDiscount,
                Id = invoice.Moslsel,
                ManId = invoice.purchaseInvoiceHeader.VendorId,
                NetAmount = invoice.NetAmount,
                Note = invoice.ItemNote,
                Price = invoice.Price,
                Quantity = invoice.Quantity,
                Unit = invoice.Unit.UnitName,
                DocumentType = "فاتورة مشتريات",
                DocumentTypeID = 2


            });
            var data2 = reverse.Select(invoice => new InvoiceForReport
            {
                InvoiceId = invoice.PurchaseInvoiceId,
                ManName = invoice.purchaseReverseHeader.Vendor.VendorName,
                ItemName = invoice.Item.ItemName,
                ItemId = invoice.ItemId,
                Date = invoice.purchaseReverseHeader.PurchaseInvoiceDate,
                Store = invoice.Store.StoreName,
                Amount = invoice.Amount * -1,
                Discount = invoice.ItemDiscount * -1,
                Id = invoice.Moslsel,
                ManId = invoice.purchaseReverseHeader.VendorId,
                NetAmount = invoice.NetAmount * -1,
                Note = invoice.ItemNote,
                Price = invoice.Price,
                Quantity = invoice.Quantity * -1,
                Unit = invoice.Unit.UnitName,
                DocumentType = "مرتجع مشتريات",
                DocumentTypeID = 10
            });

            return data1.Union(data2).ToList();
        }

        public IEnumerable<AccountStatementReport> CreateAccountStatement(int[] vendorsid, DateTime from, DateTime to, string userid)
        {
            // var invoices = _context.VendorTransactions.AsQueryable();
            var invoices = from s in _context.VendorTransactions

                           join d in contextdb.DocumentTypes on s.DocumentTypeId equals d.DocumentTypeId
                           join v in contextdb.Vendors on s.VendorId equals v.VendorId
                           orderby v.VendorId ascending
                           orderby s.DocumentId ascending
                           orderby s.TransactionDate ascending
                           select new AccountStatementReport()
                           {
                               TransactionDate = s.TransactionDate,
                               DocumentId = s.DocumentId,
                               DocumentTypeId = s.DocumentTypeId,
                               DocumentTypeName = d.DocumentTypeName,
                               ManId = v.VendorId,
                               ManName = v.VendorName,
                               Value = s.Value,
                               Note = s.Note,

                           };
            // Apply filters if arrays are not null or empty

            if (vendorsid != null && vendorsid.Any())
            {
                invoices = invoices.Where(i => vendorsid.Contains(i.ManId));
            }
            if (from.Year > 1 && to.Year > 1)
            {
                invoices = invoices.Where(i => i.TransactionDate.Date >= from && i.TransactionDate.Date <= to);
            }
            if (from.Year > 1 && to.Year == 1)
            {
                invoices = invoices.Where(i => i.TransactionDate.Date == from);

            }
            if (from.Year == 1 && to.Year > 1)
            {
                invoices = invoices.Where(i => i.TransactionDate.Date >= from && i.TransactionDate.Date <= to);
            }

            return invoices;

        }


        public IEnumerable<PurchaseInvoiceDetails> FilterDocumentData(string UserId, DateTime From, DateTime To, int DocumntID, Dictionary<string, int[]> args)
        {
            throw new NotImplementedException();
        }

        static decimal balance { get; set; } = 0;
        public IEnumerable<AccountStatementReport> CreateAccountStatement(int vendorid, DateTime from, DateTime to)
        {
            balance = 0;
            var openingBalance = contextdb.VendorTransactions.AsQueryable().Where(s => s.TransactionDate < from && s.VendorId == vendorid).GroupBy(s => new { s.VendorId} )
                 .Select(g => new AccountStatementReport
                 {
                     TransactionDate = from, 
                     DocumentId = 0, 
                     DocumentTypeId = 0, 
                     DocumentTypeName = "رصيد افتتاحي",
                     ManId = vendorid,
                     ManName = contextdb.Vendors.FirstOrDefault(v => v.VendorId == vendorid).VendorName,
                     Credit = g.Sum(s => s.Value) > 0 ? g.Sum(s => s.Value) : 0, 
                     Debit = g.Sum(s => s.Value) < 0 ? g.Sum(s => s.Value) * -1 : 0, 
                     Note = "رصيد افتتاحي",
                     Balance = GetBalance(g.Sum(s => s.Value)),
                 }).ToList();
                           

            var Debit = contextdb.VendorTransactions.AsQueryable().Where
                (s => s.VendorId == vendorid && s.TransactionDate.Date >= from && s.TransactionDate.Date <= to && s.Value < 0).OrderBy(s => s.TransactionDate)
                .Select(s => new AccountStatementReport
                {
                    TransactionDate = s.TransactionDate,
                    DocumentId = s.DocumentId,
                    DocumentTypeId = s.DocumentTypeId,
                    DocumentTypeName = contextdb.DocumentTypes.FirstOrDefault(d => d.DocumentTypeId == s.DocumentTypeId).DocumentTypeName,
                    ManId = s.VendorId,
                    ManName = contextdb.Vendors.FirstOrDefault(v => v.VendorId == s.VendorId).VendorName,
                    Credit = 0,
                    Debit = s.Value * -1, // Assuming Debit is negative value
                    Note = s.Note,
                    Balance = GetBalance(s.Value)
                }).ToList();

            var Credit = contextdb.VendorTransactions.AsQueryable().Where
               (s => s.VendorId == vendorid && s.TransactionDate.Date >= from && s.TransactionDate.Date <= to && s.Value > 0)
               .Select(s => new AccountStatementReport
               {
                   TransactionDate = s.TransactionDate,
                   DocumentId = s.DocumentId,
                   DocumentTypeId = s.DocumentTypeId,
                   DocumentTypeName = contextdb.DocumentTypes.FirstOrDefault(d => d.DocumentTypeId == s.DocumentTypeId).DocumentTypeName,
                   ManId = s.VendorId,
                   Credit = s.Value,
                   Debit = 0, // Assuming Debit is negative value
                   ManName = contextdb.Vendors.FirstOrDefault(v => v.VendorId == s.VendorId).VendorName,
                   Note = s.Note,
                   Balance = GetBalance(s.Value)
               }).ToList();
            return openingBalance.Union( Debit).Union(Credit).OrderBy(s => s.TransactionDate).ToList();
        }

     static   decimal GetBalance(decimal value)
        {

            balance += value;
            return balance;


        }
    }
}
