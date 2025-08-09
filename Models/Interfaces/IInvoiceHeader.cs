using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public interface IInvoiceHeader
    {
        public int InvoiceId { get; set; }

        public int ManId { get; set; }

        public DateTime InvoiceDate { get; set; }
        public DateTime CreateDate { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal Total { get; set; }
        public decimal NetTotal { get; set; }

        public string? Note { get; set; }

        public int Year { get; set; }


        public string UserId { get; set; }

        public int? FarmId { get; set; }
    }
}
