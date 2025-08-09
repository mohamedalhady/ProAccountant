using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class InvoiceForReport
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public DateTime Date { get; set; }
        public int ManId { get; set; }
        public string ManName { get; set; }
        public int ItemId { get; set; }
        public string   ItemName { get; set; }
        public string   Unit { get; set; }
        public string   Store { get; set; }
        public decimal   Quantity { get; set; }
        public decimal   Price { get; set; }
        public decimal   UnitCost { get; set; }
        public decimal   TotalCost { get; set; }
        public decimal Amount { get; set; }
        public decimal   Discount { get; set; }
        public decimal NetAmount { get; set; }
        public string? Note { get; set; }
        public int DocumentTypeID { get; set; }
        public string DocumentType { get; set; }

    }
}
