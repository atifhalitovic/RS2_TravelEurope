using System;
using System.Collections.Generic;
using System.Text;

namespace TravelEurope.Model.Requests
{
    public class GradoviSearchRequest
    {
        public string Naziv { get; set; } 
        public int DrzavaId { get; set; }
    }
}
