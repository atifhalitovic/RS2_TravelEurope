using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TravelEurope.Model.Requests
{
    public class PorukeInsertRequest
    {
        public int PorukaId { get; set; }
        public string Sadrzaj { get; set; }
        public int PosiljalacId { get; set; }
        public int PrimalacId { get; set; }
        public DateTime DatumVrijeme { get; set; }
    }
}
