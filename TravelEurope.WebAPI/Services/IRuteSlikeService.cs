using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelEurope.Model;
using TravelEurope.Model.Requests;

namespace TravelEurope.WebAPI.Services
{
    public interface IRuteSlikeService
    {
        List<Model.RuteSlike> Get(Model.Requests.RuteSlikeSearchRequest request);
        Model.RuteSlike Insert(Model.Requests.RuteSlikeInsertRequest request);
        RuteSlike Update(int id, RuteSlikeInsertRequest request);
        RuteSlike GetById(int id);
        bool Remove(int id);
    }
}
