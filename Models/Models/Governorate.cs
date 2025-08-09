using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Governorate
    {
        [Key]
        public int GovernorateId { get; set; }
        [Unicode(false)]
        [Column(TypeName ="nvarchar(50)")]
        [Required]
        public string GovernorateName { get; set; } = "";

    }
}
