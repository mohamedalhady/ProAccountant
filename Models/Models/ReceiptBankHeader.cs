using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ReceiptBankHeader
    {
        [Key]
        public int ReceiptBankId { get; set; }

        [ForeignKey(nameof(Bank))]
        public int BankId { get; set; }
        public Bank Bank { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
    
        [ForeignKey(nameof(_Year))]
        public int Year { get; set; }
        public _Year? _Year { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public IdentityUser? User { get; set; }

        [Unicode(false)]
        [Column(TypeName = "nvarchar(100)")]
        public string? Notes { get; set; }
        public decimal Total { get; set; }
    }
}
