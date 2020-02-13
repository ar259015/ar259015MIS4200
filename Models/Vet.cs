using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ar259015MIS4200.Models
{
    public class Vet
    {
        public int vetID { get; set; }
        [Display(Name ="Vet First Name")]
        [Required(ErrorMessage = "Pet first name is required")]
        [StringLength(20)]
        public string firstName { get; set; }
        [Display(Name ="Vet Last Name")]
        [Required(ErrorMessage = "Pet last name is required")]
        [StringLength(20)]
        public string lastName { get; set; }
        [Display(Name ="Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{4}$",
            ErrorMessage = "Phone numbers must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phone { get; set; }
        public ICollection<PetDetails> PetDetails { get; set; }
    }
}