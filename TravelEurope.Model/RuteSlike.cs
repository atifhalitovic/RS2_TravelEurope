using System;
using System.Collections.Generic;

namespace TravelEurope.Model
{
    public partial class RuteSlike
    {
        public int RuteSlikeId { get; set; }

        public int TuristRutaId { get; set; }
        public TuristRute TuristRuta { get; set; }

        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }

        public string Opis { get; set; }
    }
}