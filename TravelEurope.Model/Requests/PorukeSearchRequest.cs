using System;
using System.Collections.Generic;
using System.Text;

namespace TravelEurope.Model.Requests
{
    public class PorukeSearchRequest
    {
        public int? PorukaId { get; set; }
        public int? PrimalacId { get; set; }
        public int? PosiljalacId { get; set; }
    }
}
