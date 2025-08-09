using Microsoft.AspNetCore.Identity;
using Models.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFarmWeb.Data
{
    public class ApplicationUser:IdentityUser
    {
        [ForeignKey("Governorate")]
        public int GovernorateId { get; set; }
        public Governorate? Governorate { get; set; }
    }
}
