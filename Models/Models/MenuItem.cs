using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public  class MenuItem
    {
        [Unicode(false)]
        [Column(TypeName = "nvarchar(100)")]
        public string Id { get; set; }
        [Unicode(false)]
        [Column(TypeName = "nvarchar(100)")]
        public string Text { get; set; }
        [Unicode(false)]
        [Column(TypeName = "nvarchar(100)")]
        public string Icon { get; set; }
        [Unicode(false)]
        [Column(TypeName = "nvarchar(200)")]
        public string? Path { get; set; }
        public bool Type { get; set; }
        [Unicode(false)]
        [Column(TypeName = "nvarchar(100)")]
        public string? ParentId { get; set; }
        // خصائص إضافية للعرض الشجري

        [NotMapped]
        public List<MenuItem> Children { get; set; } = new List<MenuItem>();
        [NotMapped]
        public int Level { get; set; } = 0;
        [NotMapped]
        public bool IsExpanded { get; set; } = true;
    }
   
}
