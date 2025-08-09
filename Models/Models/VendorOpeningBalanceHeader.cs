using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class VendorOpeningBalanceHeader
    {
        [Key]
        public int VendorBalanceId { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreateDate { get; set; }

        [ForeignKey(nameof(_Year))]
        public int Year { get; set; }
        public _Year? _Year { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public IdentityUser? User { get; set; }

        public string? Note { get; set; }
    }
}
