using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Models.Models
{
    public class CustomerGroup
    {
        [Key]
        public int CustomerGroupId { get; set; }
        [Unicode(false)]
        [Column(TypeName = "nvarchar(100)")]
        public string CustomerGroupName { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public IdentityUser? User { get; set; }
    }
}
