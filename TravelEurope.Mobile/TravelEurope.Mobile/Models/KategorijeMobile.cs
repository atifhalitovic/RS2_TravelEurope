using System;
using System.Collections.Generic;
using System.Text;
using TravelEurope.Model;

namespace TravelEurope.Mobile.Models
{
    public class KategorijeMobile
    {
        public int KategorijaId { get; set; }
        public string Naziv { get; set; }
        public override string ToString()
        {
            return Naziv.ToString();
        }
    }
}
