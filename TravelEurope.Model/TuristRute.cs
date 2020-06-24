using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TravelEurope.Model;

namespace TravelEurope.Model
{
    public partial class TuristRute
    {
        public TuristRute()
        {
            RuteSlike = new List<RuteSlike>();
        }
        [Key]
        public int TuristRutaId { get; set; }
        public int KategorijaId { get; set; }
        public int LokacijaId { get; set; }
        public int TuristickiVodicId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public DateTime DatumPutovanja { get; set; }
        public int TrajanjePutovanja { get; set; }
        public decimal CijenaPaketa { get; set; }
        public decimal CijenaOsiguranja { get; set; }
        public byte[] SlikaThumb { get; set; }
        public Kategorije Kategorija { get; set; }
        public Lokacije Lokacija { get; set; }
        public TuristickiVodici TuristickiVodic { get; set; }
        public override string ToString()
        {
            var atif = Naziv + " " + Opis + ", " + DatumPutovanja.ToShortDateString();
            return atif.ToString();
        }

        public ICollection<RuteSlike> RuteSlike { get; set; }
    }
}