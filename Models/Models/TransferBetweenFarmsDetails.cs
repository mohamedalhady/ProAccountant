using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class TransferBetweenFarmsDetails
    {
        [Key]
        public int Id { get; set; }
        public int TransferId { get; set; }
        public int ItemId { get; set; }
        public Item? Item { get; set; }
        public decimal Quantity { get; set; }
    }
}
