using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ar259015MIS4200.Models
{
    public class Vet
    {
        public int vetID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public ICollection<PetDetails> PetDetails { get; set; }
    }
}