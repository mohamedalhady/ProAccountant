using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class BankOpeningBalanceDetails
    {
        public int Id { get; set; }
        public int Moslsel { get; set; }
        [ForeignKey(nameof(BankOpeningBalanceHeader))]
        public int BankBalanceId { get; set; }
        public BankOpeningBalanceHeader? BankOpeningBalanceHeader { get; set; }
        [ForeignKey(nameof(Bank))]
        public int BankId { get; set; }
        public Bank? Bank { get; set; }
        public decimal Amount { get; set; }
        public string? Note { get; set; }
    }
}
