using System;
using System.Collections.Generic;
using System.Text;

namespace TravelEurope.Model.Requests
{
    public class OcjeneInsertRequest
    {
        public int RezervacijaId { get; set; }
        public int Ocjena { get; set; }
        public string Komentar { get; set; }
    }
}
