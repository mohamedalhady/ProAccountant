using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class VendorTransaction
    {
        public int Id { get; set; }
        [ForeignKey("DocumentType")]
        public int DocumentTypeId { get; set; }
        public DocumentType? DocumentType { get; set; }
        public int DocumentId { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime CreateDate { get; set; }
        [ForeignKey("Vendor")]
        public int VendorId { get; set; }
        public Vendor? Vendor { get; set; }
        public decimal Value { get; set; }

        [ForeignKey(nameof(_Year))]
        public int Year { get; set; }
        public _Year? _Year { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public IdentityUser? User { get; set; }
        public string? Note { get; set; }

    }
}
