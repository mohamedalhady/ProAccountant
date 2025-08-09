using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ExchangeDetails
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(ExchangeHeader))]
        public int ExchangeId { get; set; }
       
        public ExchangeHeader? ExchangeHeader { get; set; }
        public int Moslsel { get; set; }
        [ForeignKey(nameof(Item))]
        public int ItemId { get; set; }
        public Item? Item { get; set; }
        [Column(TypeName = "decimal(10, 4)")]
        public decimal Quantity { get; set; }
        [ForeignKey(nameof(Unit))]
        public int UnitId { get; set; }
        public Unit? Unit { get; set; }
        public decimal Cost { get; set; }
        public string? Note { get; set; }

        [Column(TypeName = "decimal(10, 4)")]
        public decimal ConvertedQuantity { get; set; }
        public decimal ConvertedUnitCost { get; set; }
        public int UnitIdMain { get; set; }
        public decimal TotalCost { get; set; }
        public ExchangeDetails()
        {

        }
        public ExchangeDetails(int id, int exchangeId, int moslsel, int itemid, decimal quantity, 
            int unitid, decimal unitcost, string itemnote,decimal convertedquantity, decimal convertedunitcost, int unitidmain,decimal totalcost)
        {
            Id = id;
            ExchangeId = exchangeId;
            Moslsel = moslsel;
            ItemId = itemid;
            Quantity = quantity;
            UnitId = unitid;
            Cost = unitcost;
            Note = itemnote;
            ConvertedQuantity = convertedquantity;
            ConvertedUnitCost = convertedunitcost;
            UnitIdMain = unitidmain;
            TotalCost = totalcost;
        }
        public ExchangeDetails Clone()
        {
            return new ExchangeDetails
                (
                this.Id,
                this.ExchangeId,
                this.Moslsel,
                this.ItemId,
                this.Quantity,
                this.UnitId,
                this.Cost,
                this.Note,
                this.ConvertedQuantity,
                 this.ConvertedUnitCost,
                 this.UnitIdMain,
                 this.TotalCost

                );
        }

    }
}
