using System;
using System.Collections.Generic;

namespace TravelEurope.Model
{
    public partial class TuristickiVodici
    {
        public int TuristickiVodicId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public StraniJezici StraniJezik { get; set; }
        public int StraniJezikId { get; set; }
        public override string ToString()
        {
            string ImePrezimeJezik = (Ime + " " + Prezime + ", " + StraniJezik.Naziv);
            return ImePrezimeJezik.ToString();
        }
    }
}