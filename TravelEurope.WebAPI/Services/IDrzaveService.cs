using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelEurope.Model;
using TravelEurope.Model.Requests;

namespace TravelEurope.WebAPI.Services
{
    public interface IDrzaveService
    {
        List<Model.Drzave> Get(Model.Requests.DrzaveSearchRequest request);
        Model.Drzave Insert(Model.Requests.DrzaveInsertRequest request);
        Drzave Update(int id, DrzaveInsertRequest request);
        Drzave GetById(int id);
    }
}
