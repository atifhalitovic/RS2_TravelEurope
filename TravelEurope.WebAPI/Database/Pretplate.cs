using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.WebAPI.Database
{
    public class Pretplate
    {
        [Key]
        public int PretplataId { get; set; }
        public int KorisnikId { get; set; }
        public Korisnici Korisnik { get; set; }
        public int KategorijaId { get; set; }
        public Kategorije Kategorija { get; set; }
    }
}
