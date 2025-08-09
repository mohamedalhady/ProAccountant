using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Safe
    {
        public int SafeId { get; set; }
        [Unicode(false)]
        [Column(TypeName = "nvarchar(100)")]
        public string SafeName { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public IdentityUser?  User { get; set; }
    }
}
