using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Models.Models
{
    public class Expense
    {
        [Key]
        public int ExpenseId { get; set; }
        [Unicode(false)]
        [Column(TypeName = "nvarchar(50)")]
        public string ExpenseName { get; set; }
        [ForeignKey(nameof(ExpenseGroup))]
        public int ExpenseGroupId { get; set; }
        public ExpenseGroup? ExpenseGroup { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public IdentityUser? User { get; set; }
    }
}
