using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TravelEurope.Model.Requests
{
    public class PretplateInsertRequest
    {
        [Required]
        public int KategorijaId { get; set; }
        [Required]
        public int KorisnikId { get; set; }
    }
}
