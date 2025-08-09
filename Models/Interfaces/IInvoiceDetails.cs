using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public interface IInvoiceDetails
    {
        public int Id { get; set; }

        public int InvoiceId { get; set; }
        public int Moslsel { get; set; }

        public int ItemId { get; set; }
        public string ItemName { get; set; }

        [Column(TypeName = "decimal(10,4)")]
        public decimal Quantity { get; set; }
        [Column(TypeName = "decimal(10,4)")]
        public decimal ConvertedQuantity { get; set; }

        public int UnitId { get; set; }
        public string UnitName { get; set; }

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

        public int StoreId { get; set; }
        public string StoreName { get; set; }
    }
}
