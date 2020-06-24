using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TravelEurope.WebAPI.Database
{
    public partial class StraniJezici
    {
        [Key]
        public int StraniJezikId { get; set; }
        public string Naziv { get; set; }
    }
}
