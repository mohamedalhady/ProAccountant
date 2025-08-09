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
    public class Dead
    {
        [Key]
        public int DeadId { get; set; }
        [ForeignKey(nameof(Farm))]
        public int FarmId { get; set; }
        public NewFarm? Farm { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreateDate { get; set; }
        public int Year { get; set; }
        public _Year? _Year { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public IdentityUser? User { get; set; }
    }
}
