using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Lab1TeamsMembership.Models
{
    public class Team
    {
        [Key]
        public Guid Id { get; set; }

        [Required, Display(Name = "Team Name")]
        [StringLength(250)]
        public string TeamName { get; set; }


        [Required(ErrorMessage = "Email is Required."), Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(250)]
        public string Email { get; set; }


        [Display(Name = "Established Date")]
        [DataType(DataType.DateTime)]
        public DateTimeOffset? EstablishedDate { get; set; }


    }
}
