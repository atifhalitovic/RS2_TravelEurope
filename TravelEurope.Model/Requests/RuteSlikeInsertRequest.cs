using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TravelEurope.Model.Requests
{
    public class RuteSlikeInsertRequest
    {
        public int TuristRutaId { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public string Opis { get; set; }
    }
}
