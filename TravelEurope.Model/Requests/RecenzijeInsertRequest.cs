using System;
using System.Collections.Generic;
using System.Text;

namespace TravelEurope.Model.Requests
{
    public class RecenzijeInsertRequest
    {
        public int TuristRutaId { get; set; }

        public int Ocjena { get; set; }
        public DateTime DatumRecenzije { get; set; }
        public string Sadrzaj { get; set; }
    }
}
