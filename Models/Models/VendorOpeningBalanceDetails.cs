using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class VendorOpeningBalanceDetails
    {
        public int Id { get; set; }
        public int Moslsel { get; set; }
        [ForeignKey(nameof(VendorOpeningBalanceHeader))]
        public int VendorBalanceId { get; set; }
        public VendorOpeningBalanceHeader? VendorOpeningBalanceHeader { get; set; }
        [ForeignKey(nameof(Vendor))]
        public int VendorId { get; set; }
        public Vendor? Vendor { get; set; }
        public decimal Amount { get; set; }
        public string? Note { get; set; }

    }
}
