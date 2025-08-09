using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class FarmAgeStandard
    {
        [Key]
        public int FarmAgeId { get; set; }
        [ForeignKey(nameof(FarmType))]
        public int FarmTypeId { get; set; }
        public FarmType? FarmType { get; set; }
        public int StandardAge { get; set; }
    }
}
