using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class DataGridSetting
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string GridId { get; set; }
        public string Setting { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public bool IsExpand { get; set; }
     //   public DataGridColumnsFrozen? ColumnsFrozen { get; set; }
        public string? ColumnsFrozen { get; set; }
    }
}
