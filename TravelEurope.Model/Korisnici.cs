using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.Model
{
    public class Korisnici
    {
        [Key]
        public int KorisniciId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public Gradovi Grad { get; set; }
        public int GradId { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public bool Status { get; set; } = true;
        public DateTime ZadnjaAktivnost { get; set; }

        public byte[] Slika { get; set; }

        public Uloge Uloga { get; set; }
        public int UlogaId { get; set; }

        public override string ToString()
        {
            string ipg = (Ime + " " + Prezime);
            return ipg.ToString();
        }
    }
}
