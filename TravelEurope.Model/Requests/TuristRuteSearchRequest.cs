using System;
using System.Collections.Generic;
using System.Text;

namespace TravelEurope.Model.Requests
{
    public class TuristRuteSearchRequest
    {
        public int TuristRutaId { get; set; }
        public string Naziv { get; set; }
        public int? KategorijaId { get; set; }
    }
}
