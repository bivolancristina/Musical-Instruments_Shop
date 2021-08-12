using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MIShop.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Display(Name = "Profile picture")]
        public byte[] ProfilePicture { get; set; }
    }
}
