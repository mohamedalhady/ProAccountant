using Microsoft.AspNetCore.Identity;
using Models.Interfaces;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class SalesInvoiceHeader 
    {
        [Key]
        public int SalesInvoiceId { get; set; }
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public DateTime SalesInvoiceDate { get; set; }
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
    }
}
