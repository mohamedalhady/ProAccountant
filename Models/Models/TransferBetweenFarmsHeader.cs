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
    public class TransferBetweenFarmsHeader
    {
        [Key]
        public int TransferId { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreateDate { get; set; }
        [ForeignKey(nameof(FarmFrom))]
        public int FarmIdFrom { get; set; }
        public Farm? FarmFrom { get; set; }

        [ForeignKey(nameof(FarmTo))]
        public int FarmIdTo { get; set; }
        public Farm? FarmTo { get; set; }
        public int Year { get; set; }
        public _Year? _Year { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public IdentityUser? User { get; set; }
    }
}
