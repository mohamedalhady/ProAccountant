using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class FarmTransactionDetails
    {
        [Key]
        public int Id { get; set; }
        public int TransactionId { get; set; }
        public int AccountId { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
    }
}
