using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    [NotMapped]
    public class StoreMovementReport
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public DateTime Date { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public decimal Quantity { get; set; }
        public int UnitId { get; set; }
        public string UnitName { get; set; }
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public decimal Balance { get; set; }
    }
}