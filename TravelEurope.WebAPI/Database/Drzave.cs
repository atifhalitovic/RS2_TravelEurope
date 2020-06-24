using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.WebAPI.Database
{
    public class Drzave
    {
        [Key]
        public int DrzavaId { get; set; }
        public string Naziv { get; set; }
    }
}
