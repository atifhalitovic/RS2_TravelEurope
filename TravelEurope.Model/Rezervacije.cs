using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TravelEurope.Model
{
    public partial class Rezervacije
    {
        public int RezervacijaId { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public TuristRute TuristRuta { get; set; }
        public int TuristRutaId { get; set; }
        public Korisnici Korisnik { get; set; }
        public int KorisnikId { get; set; }
        public int UkupnaCijena { get; set; }
        public byte[] SlikaThumb { get; set; }
    }
}