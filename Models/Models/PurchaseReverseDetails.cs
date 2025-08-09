using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class PurchaseReverseDetails
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(purchaseReverseHeader))]
        public int PurchaseInvoiceId { get; set; }
        public int Moslsel { get; set; }
        public PurchaseReverseHeader? purchaseReverseHeader { get; set; }
        [ForeignKey(nameof(Item))]
        public int ItemId { get; set; }
        public Item? Item { get; set; }
        [Column(TypeName = "decimal(10, 4)")]
        public decimal Quantity { get; set; }
        [ForeignKey(nameof(Unit))]
        public int UnitId { get; set; }
        public Unit? Unit { get; set; }
        public decimal Price { get; set; }
        public decimal ItemDiscount { get; set; }
        public decimal Amount { get; set; }
        public decimal NetAmount { get; set; }
        [ForeignKey(nameof(Store))]
        public int StoreId { get; set; }
        public Store? Store { get; set; }
        public string? ItemNote { get; set; }
        public decimal ConvertedUnitCost { get; set; }
        public int UnitIdMain { get; set; }
        public decimal ConvertedPrice { get; set; }
        [Column(TypeName = "decimal(10, 4)")]
        public decimal ConvertedQuantity { get; set; }

        public decimal TotalCost { get; set; }
        public PurchaseReverseDetails()
        {

        }
        public PurchaseReverseDetails(int id, int purchaseInvoiceId, int moslsel, int itemid, decimal quantity, int unitid, decimal price,
            decimal itemdiscount, decimal amount, decimal netamount, int storeid, string itemnote, 
            decimal convertedquantity, decimal convertedprice, decimal convertedunitcost,int unitidmain,decimal totalcost)
        {
            Id = id;
            PurchaseInvoiceId = purchaseInvoiceId;
            Moslsel = moslsel;
            ItemId = itemid;
            Quantity = quantity;
            UnitId = unitid;
            Price = price;
            Amount = amount;
            NetAmount = netamount;
            StoreId = storeid;
            ItemDiscount = itemdiscount;
            ItemNote = itemnote;
            ConvertedQuantity = convertedquantity;
            ConvertedPrice = convertedprice;
            ConvertedUnitCost = convertedunitcost;
            UnitIdMain = unitidmain;
            TotalCost = totalcost;
        }
        public PurchaseReverseDetails Clone()
        {
            return new PurchaseReverseDetails
                (
                this.Id,
                this.PurchaseInvoiceId,
                this.Moslsel,
                this.ItemId,
                this.Quantity,
                this.UnitId,
                this.Price,
                this.ItemDiscount,
                this.Amount,
                this.NetAmount,
                this.StoreId,
                this.ItemNote,
                  this.ConvertedQuantity,
                  this.ConvertedPrice,
                  this.ConvertedUnitCost,
                  this.UnitIdMain,
                    this.TotalCost

                );
        }
    }
}
