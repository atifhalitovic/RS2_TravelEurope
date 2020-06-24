using System;
using System.Collections.Generic;
using System.Text;

namespace TravelEurope.Model.Requests
{
    public class RecenzijeSearchRequest
    {
        public int TuristRutaId { get; set; }
        public int? KorisnikId { get; set; }
    }
}
