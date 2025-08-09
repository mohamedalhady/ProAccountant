using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Models.Models;
using MyFarmWeb.Data;
using MyFarmWeb.Repository.special.Interface;

namespace MyFarmWeb.Repository.special.Class
{
    public class StoreSpecial : MainRepository<StoreMovementDetails>, IStore
    {
        private readonly MyFarmContext _context;
        public StoreSpecial(MyFarmContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<StoreMovementDetails> FilterDocumentData(string UserId, DateTime From, DateTime To, int DocumntID, Dictionary<string, int[]> args)
        {
            var invoices = _context.StoreMovementDetails.AsQueryable().Include(s => s.StoreMovementHeader)
                .Include(s => s.Item)
                .Include(s => s.Store)
                .Include(s => s.Unit)
                .Include(s => s.StoreMovementHeader).
                 ThenInclude(s => s.StoreMovementType)
                .Include(s => s.StoreMovementHeader).ThenInclude(s => s.DocumentType)
                .ToList();
              

            if (DocumntID > 0)
            {
                invoices = invoices.Where(i => i.MovementId == DocumntID).ToList();
            }
            if (args.ContainsKey("Items") && args["Items"].Length > 0)
            {

                invoices = invoices.Where(i => args["Items"].Contains((int)i.ItemId)).ToList();
            }
            if (args.ContainsKey("Stores") && args["Stores"].Length > 0)
            {
                invoices = invoices.Where(i => args["Stores"].Contains((int)i.StoreId)).ToList();

            }
   
            if (From.Year > 1 && To.Year > 1)
            {
                invoices = invoices.Where(i => i.StoreMovementHeader.Date.Date >= From && i.StoreMovementHeader.Date.Date <= To).ToList();
            }
            if (From.Year > 1 && To.Year == 1)
            {
                invoices = invoices.Where(i => i.StoreMovementHeader.Date.Date == From).ToList();

            }
            if (From.Year == 1 && To.Year > 1)
            {
                invoices = invoices.Where(i => i.StoreMovementHeader.Date.Date >= From && i.StoreMovementHeader.Date.Date <= To).ToList();
            }


            var data = invoices.Select(invoice => new StoreMovementDetails
            {
                MovementId = invoice.MovementId,
                Item = invoice.Item,
                StoreMovementHeader = invoice.StoreMovementHeader,
                Store = invoice.Store,
                Cost = invoice.Cost,
                Id = invoice.Id,
                ItemId = invoice.ItemId,
                Quantity = invoice.Quantity,
                StoreId = invoice.StoreId,
                Unit = invoice.Unit,
                UnitId = invoice.UnitId,
                Note = invoice.Note,
                ConvertedCost = invoice.ConvertedCost,
                ConvertedQuantity = invoice.ConvertedQuantity,
                TotalCost = invoice.TotalCost,
                UnitIdMain = invoice.UnitIdMain

            });
           

            return data;
        }
        

        public IEnumerable<StoreMovementDetails> GetDataWithMultiInclude(string UserId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StoreMovementDetails> GetDataWithMultiIncludeById(int InvoiceID, string UserId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ItemBalanceModel> GetItemBalance(Dictionary<string, int[]> keyValues)
        {

            var invoices = contextdb.StoreMovementDetails.Include(s => s.Item).Include(s => s.Store)
                .Include(s => s.Unit).GroupBy(smd => new { smd.ItemId, smd.StoreId, smd.UnitIdMain }).
                Select(g => new ItemBalanceModel 
                { 
                 ItemId = g.Key.ItemId,
                 StoreId = g.Key.StoreId,
                 UnitId = g.Key.UnitIdMain,
                 ItemName = g.FirstOrDefault().Item.ItemName ,
                 StoreName = g.FirstOrDefault().Store.StoreName,
                 UnitName = g.FirstOrDefault().Unit.UnitName,
                 Balance = g.Sum(smd => smd.ConvertedQuantity),
                 TotalCost = g.Sum(smd => smd.TotalCost)
                }).ToList();
            if (keyValues.ContainsKey("Items") && keyValues["Items"].Length > 0)
            {

                invoices = invoices.Where(i => keyValues["Items"].Contains((int)i.ItemId)).ToList();
            }
            if (keyValues.ContainsKey("Stores") && keyValues["Stores"].Length > 0)
            {
                invoices = invoices.Where(i => keyValues["Stores"].Contains((int)i.StoreId)).ToList();

            }
            return invoices;
        }
    }
    
}
