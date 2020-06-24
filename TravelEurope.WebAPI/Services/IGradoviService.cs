using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelEurope.Model;
using TravelEurope.Model.Requests;

namespace TravelEurope.WebAPI.Services
{
    public interface IGradoviService
    {
        List<Model.Gradovi> Get(Model.Requests.GradoviSearchRequest request);
        Model.Gradovi Insert(Model.Requests.GradoviInsertRequest request);
        Gradovi Update(int id, GradoviInsertRequest request);
        Gradovi GetById(int id);
    }
}
