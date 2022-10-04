using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace _Lab1TeamsMembership.Data
{
    public class ApplicationUser:IdentityUser
    {
        [Required,Display(Name= "First Name")]
        public string FirstName { get; set; } = String.Empty;

        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Display(Name = "Birth Date")]
        [DataType(DataType.DateTime)]
        public DateTimeOffset BirthDate { get; set; }
    }

}
