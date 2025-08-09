using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class CustomerOpeningBalanceDetails
    {
        public int Id { get; set; }
        public int Moslsel { get; set; }
        [ForeignKey(nameof(CustomerOpeningBalanceHeader))]
        public int CustomerBalanceId { get; set; }
        public CustomerOpeningBalanceHeader? CustomerOpeningBalanceHeader { get; set; }
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public decimal Amount { get; set; }
        public string? Note { get; set; }
   
    }
}
