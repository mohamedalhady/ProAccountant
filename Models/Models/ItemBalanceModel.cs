using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    [NotMapped]
    public class ItemBalanceModel
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
      
        public string UnitName { get; set; }
        public int UnitId { get; set; }
        public decimal Balance { get; set; }
        public int StoreId { get; set; }
        public string StoreName { get; set; }

        public decimal TotalCost { get; set; }

    }
}
