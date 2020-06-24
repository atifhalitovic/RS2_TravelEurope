using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TravelEurope.Model.Requests
{
    public class TuristRuteInsertRequest
    {
        public int TuristRutaId { get; set; }
        [Required]
        public string Naziv { get; set; }
        [Required]
        public string Opis { get; set; }
        [Required]
        public int TuristickiVodicId { get; set; }
        [Required]
        public int LokacijaId { get; set; }
        [Required]
        public int KategorijaId { get; set; }
        [Required]
        public DateTime DatumPutovanja { get; set; }
        [Required]
        public int TrajanjePutovanja { get; set; }
        [Required]
        public decimal CijenaPaketa { get; set; }
        [Required]
        public decimal CijenaOsiguranja { get; set; }
    }
}
