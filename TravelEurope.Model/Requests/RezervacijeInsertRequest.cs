using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TravelEurope.Model.Requests
{
    public class RezervacijeInsertRequest
    {
        public int RezervacijaId { get; set; }
        [Required]
        public DateTime DatumRezervacije { get; set; }
        [Required]
        public int TuristRutaId { get; set; }
        [Required]
        public int KorisnikId { get; set; }
    }
}
