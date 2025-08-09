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
    public class DocumentType
    {
        [Key]
        public int DocumentTypeId { get; set; }
        [Unicode(false)]
        [Column(TypeName = "nvarchar(50)")]
        public string DocumentTypeName { get; set; }

        /*
         1-فاتورة بيع
         2- فاتروة شراء 
         3-مصروف
         4-ايراد
         5-واردمخزن
         6-منصرف مخزن
        7-مقبوض
        8-مدفوع
         */

    }
}
