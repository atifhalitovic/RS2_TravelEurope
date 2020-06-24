using System;
using System.Collections.Generic;
using System.Text;

namespace TravelEurope.Model.Requests
{
    public class KorisniciSearchRequest
    {
        public string ImePrezime { get; set; }
        public string UserName { get; set; }
        public bool Aktivan { get; set; }
    }
}
