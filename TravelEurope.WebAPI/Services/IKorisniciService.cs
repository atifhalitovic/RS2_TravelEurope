using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelEurope.Model;
using TravelEurope.Model.Requests;

namespace TravelEurope.WebAPI.Services
{
    public interface IKorisniciService
    {
        List<Model.Korisnici> Get(Model.Requests.KorisniciSearchRequest request);
        Model.Korisnici Insert(Model.Requests.KorisniciInsertRequest request);
        Korisnici GetById(int id);
        Korisnici Update(int id, KorisniciUpdateRequest request);
        Korisnici MyProfile();
        Korisnici UpdateProfile(KorisniciUpdateProfilRequest request);
        Model.Korisnici Authenticiraj(string username, string pass);
    }
}
