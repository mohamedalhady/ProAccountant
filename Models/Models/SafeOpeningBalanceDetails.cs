using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class SafeOpeningBalanceDetails
    {
        public int Id { get; set; }
        public int Moslsel { get; set; }
        [ForeignKey(nameof(SafeOpeningBalanceHeader))]
        public int SafeBalanceId { get; set; }
        public SafeOpeningBalanceHeader? SafeOpeningBalanceHeader { get; set; }
        [ForeignKey(nameof(Safe))]
        public int SafeId { get; set; }
        public Safe? Safe { get; set; }
        public decimal Amount { get; set; }
        public string? Note { get; set; }
    }
}
