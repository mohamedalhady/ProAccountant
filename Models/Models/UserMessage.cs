using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class UserMessage
    {
        public string UserName { get; set; }
        public bool CurrentUser { get; set; }
        public string Message { get; set; }
        public DateTime DateSent { get; set; }
    }
}
