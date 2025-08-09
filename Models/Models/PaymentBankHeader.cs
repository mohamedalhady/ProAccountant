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
    public class PaymentBankHeader
    {

        [Key]
        public int PaymentBankId { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreateDate { get; set; }

        public int BankId { get; set; }
        public Bank Bank { get; set; }

        //[ForeignKey(nameof(Farm))]
        //public int FarmId { get; set; }
        //public NewFarm? Farm { get; set; }
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
