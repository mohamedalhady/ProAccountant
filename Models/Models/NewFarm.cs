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
    public class NewFarm
    {
        [Key]
        public int NewFarmId { get; set; }

        [ForeignKey("Farm")]
        public int FarmId { get; set; }
        public Farm? Farm { get; set; }
        public int Count { get; set; }
        [Required]
        public DateTime DateEntry { get; set; }
        [Required]
        public DateTime SalesDate { get; set; }
        public bool Status { get; set; }
        [ForeignKey(nameof(_Year))]
        public int Year { get; set; }
        public _Year? _Year { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public IdentityUser? User { get; set; }

        
        [ForeignKey("Vendor")]
       
        public int FeedVendor { get; set; }
        public Vendor? Vendor { get; set; }

        [ForeignKey("Vendor2")]
     
        public int ChickenVendor { get; set; }
        public Vendor? Vendor2 { get; set; }

    }
}
