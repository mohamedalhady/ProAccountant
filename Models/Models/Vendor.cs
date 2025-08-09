using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Vendor
    {
        [Key]
        public int VendorId { get; set; }

        [Unicode(false)]
        [Column(TypeName = "nvarchar(100)")]
        public string VendorName { get; set; }

        [Unicode(false)]
        [Column(TypeName = "nvarchar(20)")]
        [Phone]
        public string? Phone { get; set; }
        [ForeignKey(nameof(VendorGroup))]
        public int VendorGroupId { get; set; }
        public VendorGroup? VendorGroup { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public IdentityUser? User { get; set; }
    }
}
