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
    public class _Year
    {
        [Key]
        public int Year { get; set; }
        public int YearName { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public bool Status { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public IdentityUser? User { get; set; }
    }
}
