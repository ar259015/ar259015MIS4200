using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ar259015MIS4200.Models
{
    public class PetDetails
    {
        [Key]
        public int petdetailID { get; set; }
        [Display(Name ="Age of Pet")]
        [Required]
        public int age { get; set; }
        [Display(Name ="Owner's First Name")]
        [Required(ErrorMessage = "Owner First name is required")]
        [StringLength(20)]
        public string ownerfirstName { get; set; }
        [Display(Name ="Owner's Last Name")]
        [Required(ErrorMessage = "Owner last name is required")]
        [StringLength(20)]
        public string ownerlastName { get; set; }
        public int petID { get; set; }
        public virtual Pet Pet { get; set; }
        public int vetId { get; set; }
        public virtual Vet Vet { get; set; }
        
    }
}