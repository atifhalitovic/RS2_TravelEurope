using System;
using System.Collections.Generic;

namespace TravelEurope.Model
{
    public partial class Gradovi
    {
        public int GradId { get; set; }
        public string Naziv { get; set; }
        public int DrzavaId { get; set; }
        public Drzave Drzava { get; set; }
        public override string ToString()
        {
            return Naziv.ToString();
        }
    }
}
