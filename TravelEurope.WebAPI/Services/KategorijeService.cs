using AutoMapper;
using TravelEurope.Model.Requests;
using TravelEurope.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.WebAPI.Services
{
    public class KategorijeService : IKategorijeService
    {
        private readonly TravelEurope_Context _context;

        private readonly IMapper _mapper;

        public KategorijeService(TravelEurope_Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Kategorije> Get(KategorijeSearchRequest request)
        {
            var query = _context.Kategorije.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.Naziv.ToLower().Contains(request.Naziv.ToLower()));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Kategorije>>(list);
        }

        public Model.Kategorije Insert(KategorijeInsertRequest request)
        {
            Database.Kategorije entity = _mapper.Map<Database.Kategorije>(request);

            _context.Kategorije.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Kategorije>(entity);
        }
        public Model.Kategorije GetById(int id)
        {
            var query = _context.Kategorije.AsQueryable();

            query = query.Where(x => x.KategorijaId == id);

            var entity = query.FirstOrDefault();

            return _mapper.Map<Model.Kategorije>(entity);
        }

        public Model.Kategorije Update(int id, KategorijeInsertRequest request)
        {
            Database.Kategorije entity = _context.Kategorije.Where(x => x.KategorijaId == id).FirstOrDefault();

            _context.Kategorije.Attach(entity);
            _context.Kategorije.Update(entity);

            entity = _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Kategorije>(entity);
        }
    }
}
