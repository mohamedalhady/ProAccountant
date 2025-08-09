using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class AccountType
    {
        [Key]
        public int AccountTypeId { get; set; }
        [Unicode(false)]
        [Column(TypeName ="nvarchar(100)")]
        public string AccountTypeName { get; set; }
    }
}
