using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Models.Models
{
    public class ExpenseGroup
    {
        [Key]
        public int ExpenseGroupId { get; set; }
        [Unicode(false)]
        [Column(TypeName = "nvarchar(50)")]
        public string ExpenseGroupName { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public IdentityUser? User { get; set; }

    }
}
