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
    public class ReceiptBankDetails
    {

        [Key]
        public int Id { get; set; }
        public int Moslsel { get; set; }
        [ForeignKey(nameof(ReceiptBankHeader))]
        public int ReceiptBankId { get; set; }
        public ReceiptBankHeader? ReceiptBankHeader { get; set; }


        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }
        public Customer? Customer { get; set; }

        [ForeignKey("Vendor")]
        public int? VendorId { get; set; }
        public Vendor? Vendor { get; set; }
        public decimal Amount { get; set; }
        [Unicode(false)]
        [Column(TypeName = "nvarchar(100)")]
        public string? Notes { get; set; }


        public ReceiptBankDetails(int id, int moslsel, int receiptBankId, int? customerId, int? vendorId, decimal amount, string notes)
        {
            Id = id;
            Moslsel = moslsel;
            ReceiptBankId = receiptBankId;

            CustomerId = customerId;

            VendorId = vendorId;

            Amount = amount;
            Notes = notes;
        }

        public ReceiptBankDetails()
        {

        }

        public ReceiptBankDetails Clone()
        {
            return new ReceiptBankDetails(
                this.Id,
                this.Moslsel,
                this.ReceiptBankId,
                this.CustomerId,
                this.VendorId,
                this.Amount,
                this.Notes
                );

        }
    }

}

