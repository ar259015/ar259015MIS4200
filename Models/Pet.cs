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
        [Display(Name ="First Name")]
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime petSince { get; set; }
        public ICollection<PetDetails> PetDetails { get; set; }
    }
}