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
    public class VendorGroup
    {
        [Key]
        public int VendorGroupId { get; set; }

        [Unicode(false)]
        [Column(TypeName = "nvarchar(50)")]
        public string VendorGroupName { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public IdentityUser? User { get; set; }
    }
}
