using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.WebAPI.Database
{
    public class Gradovi
    {
        [Key]
        public int GradId { get; set; }
        public string Naziv { get; set; }
        public Drzave Drzava{ get; set; }
        public int DrzavaId { get; set; }
    }
}
