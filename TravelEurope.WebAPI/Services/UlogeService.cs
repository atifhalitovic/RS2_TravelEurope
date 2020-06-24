using AutoMapper;
using TravelEurope.Model.Requests;
using TravelEurope.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.WebAPI.Services
{
    public class UlogeService: IUlogeService
    {
        private readonly TravelEurope_Context _context;

        private readonly IMapper _mapper;

        public UlogeService(TravelEurope_Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Uloge> Get()
        {
            var query = _context.Uloge.AsQueryable();

            var list = query.ToList();

            return _mapper.Map<List<Model.Uloge>>(list);
        }

        public Model.Uloge Insert(UlogeInsertRequest request)
        {
            Database.Uloge entity = _mapper.Map<Database.Uloge>(request);

            _context.Uloge.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Uloge>(entity);
        }
    }
}
