using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Models.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        [Unicode(false)]
        [Column(TypeName = "nvarchar(100)")]
        public string ItemName { get; set; }
        [ForeignKey(nameof(ItemGroup))]
        public int ItemGroupId { get; set; }
        public ItemGroup? ItemGroup { get; set; }

        [ForeignKey("Store")]
        public int StoreId { get; set; }
        public Store? Store { get; set; }

        [ForeignKey("Unit")]
        public int UnitId { get; set; }
        public Unit? Unit { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal PurchasePrice { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public IdentityUser? User { get; set; }
    }
}
