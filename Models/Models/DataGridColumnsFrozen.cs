using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class DataGridColumnsFrozen
    {
        public int Id { get; set; }
        [ForeignKey("Grid")]
        public int GridId { get; set; }
        public DataGridSetting? Grid { get; set; }

        public string? ColumnsFrozenSetting { get; set; }



        [NotMapped]
        public string ColumnKey { get; set; }
        [NotMapped]
        public string ColumnTitle { get; set; }
        
        


    }
}
