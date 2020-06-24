﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.WebAPI.Database
{
    public class Uloge
    {
        [Key]
        public int UlogaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
    }
}
