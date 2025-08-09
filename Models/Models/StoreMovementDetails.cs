using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class StoreMovementDetails
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(StoreMovementHeader))]
        public int MovementId { get; set; }
        public StoreMovementHeader? StoreMovementHeader { get; set; }

        [ForeignKey(nameof(Item))]
        public int ItemId { get; set; }
     
        public Item? Item { get; set; }

        [ForeignKey("Store")]
        public int StoreId { get; set; }
      
        public Store? Store { get; set; }
        [Column(TypeName = "decimal(10, 4)")]
        public decimal Quantity { get; set; }
        [Column(TypeName = "decimal(10, 4)")]
        public decimal ConvertedQuantity { get; set; }

        [ForeignKey(nameof(Unit))]
        public int UnitId { get; set; }
      
        public Unit? Unit { get; set; }
        public int UnitIdMain { get; set; }
        public decimal Cost { get; set; }
        public decimal ConvertedCost { get; set; }
        public string? Note { get; set; }
        public decimal TotalCost { get; set; }
    }
}
