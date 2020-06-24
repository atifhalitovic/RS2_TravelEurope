using System;
using System.Collections.Generic;
using System.Text;
using TravelEurope.Model;

namespace TravelEurope.Mobile.Models
{
    public class TuristRuteMobile
    {
        public int TuristRutaId { get; set; }
        public int KategorijaId { get; set; }
        public int LokacijaId { get; set; }
        public int TuristickiVodicId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public DateTime DatumPutovanja { get; set; }
        public DateTime DatumPovratka { get; set; }
        public int TrajanjePutovanja { get; set; }
        public decimal CijenaPaketa { get; set; }
        public decimal CijenaOsiguranja { get; set; }
        public decimal UkupnaCijena { get; set; }
        public Kategorije Kategorija { get; set; }
        public Lokacije Lokacija { get; set; }
        public TuristickiVodici TuristickiVodic { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public ICollection<RuteSlike> RuteSlike { get; set; }
        public override string ToString()
        {
            return Naziv.ToString();
        }
    }
}
