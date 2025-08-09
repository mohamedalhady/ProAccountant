using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    [NotMapped]
    public class AccountStatementReport
    {
        public DateTime TransactionDate { get; set; }

        public int ManId { get; set; }

        public string ManName { get; set; }
        public int DocumentId { get; set; }
        public int DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public decimal Balance { get; set; }
        public decimal Value { get; set; }
        public string Note { get; set; }



    }
}
