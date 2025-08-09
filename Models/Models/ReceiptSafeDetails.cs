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
    public class ReceiptSafeDetails
    {
     

        [Key]
        public int Id { get; set; }
        public int Moslsel { get; set; }
        [ForeignKey(nameof(ReceiptSafeHeader))]
        public int ReceiptSafeId { get; set; }
        public ReceiptSafeHeader? ReceiptSafeHeader { get; set; }


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


        public ReceiptSafeDetails(int id, int moslsel, int receiptSafeId, int? customerId, int? vendorId, decimal amount, string notes)
        {
            Id = id;
            Moslsel = moslsel;
            ReceiptSafeId = receiptSafeId;
           
            CustomerId = customerId;
       
            VendorId = vendorId;
         
            Amount = amount;
            Notes = notes;
        }

        public ReceiptSafeDetails()
        {
            
        }

        public ReceiptSafeDetails Clone()
        {
            return new ReceiptSafeDetails(
                this.Id,
                this.Moslsel,
                this.ReceiptSafeId,
                this.CustomerId,
                this.VendorId,
                this.Amount,
                this.Notes
                );
         
        }
    }


}
