using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TravelEurope.WebAPI.Database
{
    public partial class Rezervacije
    {
        [Key]
        public int RezervacijaId { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public TuristRute TuristRuta { get; set; }
        public int TuristRutaId { get; set; }
        public Korisnici Korisnik { get; set; }
        public int KorisnikId { get; set; }
    }
}