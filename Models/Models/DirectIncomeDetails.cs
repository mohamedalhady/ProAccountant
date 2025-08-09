using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class DirectIncomeDetails
    {
        [Key]
        public int Id { get; set; }
        public int DirectIncomeId { get; set; }
        [ForeignKey(nameof(Income))]
        public int IncomeId { get; set; }
        public Income? Income { get; set; }

        public decimal Amount { get; set; }
    }
}
