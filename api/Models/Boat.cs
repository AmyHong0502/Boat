﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Boat
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BoatId { get; set; }
        public string BoatName { get; set; }
        public string Picture { get; set; }
        public double LengthInFeet { get; set; }
        public string Make { get; set; }
        public string Description { get; set; }
    }
}
