using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TravelEurope.Model.Requests
{
    public class GradoviInsertRequest
    {
        [Required]
        public string Naziv { get; set; }
        [Required]
        public int DrzavaId { get; set; }
    }
}
