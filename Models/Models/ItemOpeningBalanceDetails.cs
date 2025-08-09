using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ItemOpeningBalanceDetails
    {

        public int Id { get; set; }
        public int Moslsel { get; set; }
        [ForeignKey(nameof(ItemOpeningBalanceHeader))]
        public int ItemBalanceId { get; set; }
        public ItemOpeningBalanceHeader? ItemOpeningBalanceHeader { get; set; }
        [ForeignKey(nameof(Item))]
        public int ItemId { get; set; }
        public Item? Item { get; set; }
        public decimal Quantity { get; set; }
        public decimal ConvertedQuantity { get; set; }
        [ForeignKey(nameof(Unit))]
        public int UnitId { get; set; }
        public Unit? Unit { get; set; }
        public int UnitIdMain { get; set; }
        public decimal UnitCost { get; set; }
        public decimal ConvertedUnitCost { get; set; }
        public decimal TotalCost { get; set; }
        [ForeignKey(nameof(Store))]
        public int StoreId { get; set; }
        public Store? Store { get; set; }
        public string? ItemNote { get; set; }


        public ItemOpeningBalanceDetails()
        {
            
        }

        public ItemOpeningBalanceDetails( int id,int moslsel, int itemBalanceId, int itemId, decimal quantity, decimal convertedQuantity, int unitId,  int unitIdMain, decimal unitCost, decimal convertedUnitCost, decimal totalCost, int storeId,  string? itemNote)
        {
            Id = id;
            Moslsel = moslsel;
            ItemBalanceId = itemBalanceId;
            ItemId = itemId;
            Quantity = quantity;
            ConvertedQuantity = convertedQuantity;
            UnitId = unitId;
            UnitIdMain = unitIdMain;
            UnitCost = unitCost;
            ConvertedUnitCost = convertedUnitCost;
            TotalCost = totalCost;
            StoreId = storeId;
            ItemNote = itemNote;
        }

        public ItemOpeningBalanceDetails Clone()
        {
            return new ItemOpeningBalanceDetails
            {
                Id = this.Id,
                Moslsel = this.Moslsel,
                ItemBalanceId = this.ItemBalanceId,
                ItemId = this.ItemId,
                Quantity = this.Quantity,
                ConvertedQuantity = this.ConvertedQuantity,
                UnitId = this.UnitId,
                UnitIdMain = this.UnitIdMain,
                UnitCost = this.UnitCost,
                ConvertedUnitCost = this.ConvertedUnitCost,
                TotalCost = this.TotalCost,
                StoreId = this.StoreId,
                ItemNote = this.ItemNote
            };
        }
    }
}
