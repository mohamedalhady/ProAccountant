using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Models.Models
{
    public class SalesInvoiceDetails
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(SalesInvoiceHeader))]
        public int SalesInvoiceId { get; set; }
        public int Moslsel { get; set; }

        public SalesInvoiceHeader? SalesInvoiceHeader { get; set; }
        [ForeignKey(nameof(Item))]
        public int ItemId { get; set; }
        public Item? Item { get; set; }
        [Column(TypeName = "decimal(10,4)")]
        public decimal Quantity { get; set; }
        [Column(TypeName ="decimal(10,4)")]
        public decimal ConvertedQuantity { get; set; }
        [ForeignKey(nameof(Unit))]
        public int UnitId { get; set; }
        public Unit? Unit { get; set; }

        public int UnitIdMain { get; set; }
        public decimal Price { get; set; }
        public decimal ConvertedPrice { get; set; }
        public decimal UnitCost { get; set; }
        public decimal ConvertedUnitCost { get; set; }
        public decimal TotalCost { get; set; }
       
        public decimal ItemDiscount { get; set; }

        public decimal Amount { get; set; }
        public decimal NetAmount { get; set; }

        public string? ItemNote { get; set; }

        [ForeignKey(nameof(Store))]
        public int StoreId { get; set; }
        public Store? Store { get; set; }
        public SalesInvoiceDetails()
        {

        }
        public SalesInvoiceDetails(int id, int salesInvoiceId, int moslsel, int itemid, decimal quantity, int unitid, int unitidmain,
            decimal price, decimal unitcost, decimal totalcost, decimal itemdiscount
            , decimal amount, decimal netamount, int storeid, string itemnote,decimal convertedquantity , decimal convertedprice,decimal convertedunitcost)
        {
            Id = id;
            SalesInvoiceId = salesInvoiceId;
            Moslsel = moslsel;
            ItemId = itemid;
            Quantity = quantity;
            UnitId = unitid;
            Price = price;
            UnitCost = unitcost;
            TotalCost = totalcost;
            Amount = amount;
            NetAmount = netamount;
            StoreId = storeid;
            ItemDiscount = itemdiscount;
            ItemNote = itemnote;
            ConvertedQuantity = convertedquantity;
            ConvertedPrice = convertedprice;
            ConvertedUnitCost = convertedunitcost;
            UnitIdMain = unitidmain;
        }
        public SalesInvoiceDetails Clone()
        {
            return new SalesInvoiceDetails
                (
                this.Id,
                this.SalesInvoiceId,
                this.Moslsel,
                this.ItemId,
                this.Quantity,
                this.UnitId,
                this.UnitIdMain,
                this.Price,
                this.UnitCost,
                this.TotalCost,
                this.ItemDiscount,
                this.Amount,
                this.NetAmount,
                this.StoreId,
                this.ItemNote,
                this.ConvertedQuantity,
                this.ConvertedPrice,
                this.ConvertedUnitCost
               
                );
        }

   
    }
}
