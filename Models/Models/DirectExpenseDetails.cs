using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class DirectExpenseDetails
    {
        [Key]
        public int Id { get; set; }
        public int DirectExpenseId { get; set; }
        [ForeignKey(nameof(Expense))]
        public int ExpenseId { get; set; }
        public Expense? Expense { get; set; }

        public decimal Amount { get; set; }

    }
}
