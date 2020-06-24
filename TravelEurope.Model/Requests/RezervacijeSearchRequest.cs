using System;
using System.Collections.Generic;
using System.Text;

namespace TravelEurope.Model.Requests
{
    public class RezervacijeSearchRequest
    {
        public int? RezervacijaId { get; set; }
        public int? KorisnikId { get; set; }
        public int? TuristRutaId { get; set; }
        public int? KategorijaId { get; set; }
        public DateTime? DatumRezervacijeOd { get; set; }
        public DateTime? DatumRezervacijeDo { get; set; }
    }
}
