using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Models.Models
{
    public class Store
    {
        [Key]
        public int StoreId { get; set; }
        [Unicode(false)]
        [Column(TypeName = "nvarchar(50)")]

        public string StoreName { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public IdentityUser? User { get; set; }
    }
}
