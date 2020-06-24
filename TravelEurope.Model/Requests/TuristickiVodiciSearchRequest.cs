using System;
using System.Collections.Generic;
using System.Text;

namespace TravelEurope.Model.Requests
{
    public class TuristickiVodiciSearchRequest
    {
        public int TuristickiVodicId { get; set; }
        public string Ime { get; set; }
        public int? StraniJezikId { get; set; }
    }
}
