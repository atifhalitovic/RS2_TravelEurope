using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.Model
{
    public class Kategorije
    {
        public int KategorijaId { get; set; }
        public string Naziv { get; set; }
        public override string ToString()
        {
            return Naziv.ToString();
        }
    }
}
