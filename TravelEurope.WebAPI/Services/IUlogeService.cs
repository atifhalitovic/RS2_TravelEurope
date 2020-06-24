using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.WebAPI.Services
{
    public interface IUlogeService
    {
        List<Model.Uloge> Get();
        Model.Uloge Insert(Model.Requests.UlogeInsertRequest request);
    }
}
