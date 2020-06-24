using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TravelEurope.WebAPI.Database
{
    public partial class TuristickiVodici
    {
        [Key]
        public int TuristickiVodicId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public StraniJezici StraniJezik { get; set; }
        public int StraniJezikId { get; set; }
    }
}