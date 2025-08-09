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
    public class FarmType
    {
        [Key]
        public int FarmTypeId { get; set; }
        [Unicode(false)]
        [Column(TypeName = "nvarchar(50)")]
        public string FameTypeName { get; set; }
    }
}
