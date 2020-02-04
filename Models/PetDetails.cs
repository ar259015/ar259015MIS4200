﻿using System;
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
        public int age { get; set; }
        public string ownerfirstName { get; set; }
        public string ownerlastName { get; set; }
        public int petID { get; set; }
        public virtual Pet Pet { get; set; }
        public int vetId { get; set; }
        public virtual Vet Vet { get; set; }
    }
}