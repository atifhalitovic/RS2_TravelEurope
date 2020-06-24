using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.Model
{
    public class Poruke
    {
        [Key]
        public int PorukaId { get; set; }
        public string Sadrzaj { get; set; }
        public Korisnici Primalac { get; set; }
        public int PrimalacId { get; set; }
        public Korisnici Posiljalac { get; set; }
        public int PosiljalacId { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public string PosiljaocInfo { get; set; }
        public string PrimaocInfo { get; set; }
    }
}
