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
        [Display(Name ="First Name")]
        public string firstName { get; set; }
        [Display(Name ="Last Name")]
        public string lastName { get; set; }
        [Display(Name ="Phone Number")]
        public string phone { get; set; }
        public ICollection<PetDetails> PetDetails { get; set; }
    }
}