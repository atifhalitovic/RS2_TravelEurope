using System;
using System.Collections.Generic;
using System.Text;
using TravelEurope.Model;

namespace TravelEurope.Mobile.Models
{
    public class RezervacijeMobile
    {
        public int RezervacijaId { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public TuristRuteMobile TuristRuta { get; set; }
        public DateTime DatumPovratka { get; set; }
        public int TuristRutaId { get; set; }
        public Korisnici Korisnik { get; set; }
        public int KorisnikId { get; set; }
        public decimal UkupnaCijena { get; set; }
        public byte[] SlikaThumb { get; set; }
    }
}
