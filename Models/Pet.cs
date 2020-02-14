using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ar259015MIS4200.Models
{
    public class Pet
    {
        [Key]
        public int petID { get; set; }
        [Display(Name = "Pet First Name")]
        [Required(ErrorMessage = "Pet first name is required")]
        [StringLength(20)]
        public string firstName { get; set; }
        [Display(Name = "Pet Last Name")]
        [Required(ErrorMessage ="Pet last name is required")]
        [StringLength(20)]
        public string lastName { get; set; }
        [Display(Name = "When did you join us?")]
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime petSince { get; set; }
        [Display(Name = "Breed of your pet")]
        [Required]
        public string Breed { get; set; }
        public ICollection<PetDetails> PetDetails { get; set; }

        public string fullName
        {
            get
            {
                return lastName + ", " + firstName;
            }
        }

    }
}