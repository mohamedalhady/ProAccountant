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
    public class UnitsConverter
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("UnitMain")]
        public int UnitMainId { get; set; }

        [ForeignKey("UnitSub")]
        public int UnitSubId { get; set; }
        public float ConversionFactor { get; set; }

        public Unit? UnitMain { get; set; }
        public Unit? UnitSub { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public IdentityUser? User { get; set; }

    }
}
