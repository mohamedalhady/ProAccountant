using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class PurchaseReverseHeader
    {
        [Key]
        public int PurchaseInvoiceId { get; set; }
        [ForeignKey(nameof(Vendor))]
        public int VendorId { get; set; }
        public Vendor? Vendor { get; set; }
        public DateTime PurchaseInvoiceDate { get; set; }
        public DateTime CreateDate { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal Total { get; set; }
        public decimal NetTotal { get; set; }

        public string? Note { get; set; }

        [ForeignKey(nameof(_Year))]
        public int Year { get; set; }
        public _Year? _Year { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public IdentityUser? User { get; set; }
        [ForeignKey(nameof(Farm))]
        public int? FarmId { get; set; }
        public NewFarm? Farm { get; set; }
       
        public int Reference { get; set; }
       
    }
}
