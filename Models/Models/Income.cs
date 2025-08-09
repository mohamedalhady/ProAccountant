using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Models.Models
{
    public class Income
    {
        [Key]
        public int IncomeId { get; set; }
        [Unicode(false)]
        [Column(TypeName = "nvarchar(50)")]
        public string IncomeName { get; set; }
        [ForeignKey(nameof(IncomeGroup))]
        public int IncomeGroupId { get; set; }
        public IncomeGroup? IncomeGroup { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public IdentityUser? User { get; set; }
    }
}
