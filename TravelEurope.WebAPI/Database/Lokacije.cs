using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TravelEurope.WebAPI.Database
{
    public partial class Lokacije
    {
        [Key]
        public int LokacijaId { get; set; }
        public string Naziv { get; set; }
        public int DrzavaId { get; set; }
        public Drzave Drzava { get; set; }
    }
}
