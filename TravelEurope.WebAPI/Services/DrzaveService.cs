using AutoMapper;
using TravelEurope.Model.Requests;
using TravelEurope.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.WebAPI.Services
{
    public class DrzaveService : IDrzaveService
    {
        private readonly TravelEurope_Context _context;

        private readonly IMapper _mapper;

        public DrzaveService(TravelEurope_Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Drzave> Get(DrzaveSearchRequest request)
        {
            var query = _context.Drzave.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.Naziv.ToLower().Contains(request.Naziv.ToLower()));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Drzave>>(list);
        }

        public Model.Drzave Insert(DrzaveInsertRequest request)
        {
            Database.Drzave entity = _mapper.Map<Database.Drzave>(request);

            _context.Drzave.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Drzave>(entity);
        }
        public Model.Drzave GetById(int id)
        {
            var query = _context.Drzave.AsQueryable();

            query = query.Where(x => x.DrzavaId == id);

            var entity = query.FirstOrDefault();

            return _mapper.Map<Model.Drzave>(entity);
        }

        public Model.Drzave Update(int id, DrzaveInsertRequest request)
        {
            Database.Drzave entity = _context.Drzave.Where(x => x.DrzavaId == id).FirstOrDefault();

            _context.Drzave.Attach(entity);
            _context.Drzave.Update(entity);

            entity = _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Drzave>(entity);

        }
    }
}
