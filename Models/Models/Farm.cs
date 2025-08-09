using Microsoft.AspNetCore.Identity;
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
    public class Farm
    {
        [Key]
        public int FarmId { get; set; }
        [Unicode(false)]
        [Column(TypeName = "nvarchar(50)")]
        //[Required(ErrorMessage ="يجب ادخال اسم المزرعه")]
        public string FarmName { get; set; }

        
        [Required]
        [ForeignKey(nameof(FarmType))]
        //[MinLength(1,ErrorMessage ="يجب ادخال نوع المزرعه"),MaxLength(int.MaxValue)]
        public int FarmTypeId { get; set; }
        public FarmType? FarmType { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public IdentityUser? User { get; set; }
    }
}
