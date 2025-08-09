using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Models.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Unicode(false)]
        [Column(TypeName = "nvarchar(100)")]
        public string CustomerName { get; set; }

        [Unicode(false)]
        [Column(TypeName = "nvarchar(20)")]
        [Phone]
        public string? Phone { get; set; }
        [ForeignKey(nameof(CustomerGroup))]
        public int CustomerGroupId { get; set; }
        public CustomerGroup? CustomerGroup { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public IdentityUser? User { get; set; }
    }
}
