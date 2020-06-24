using AutoMapper;
using TravelEurope.Model.Requests;
using TravelEurope.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.WebAPI.Services
{
    public class GradoviService : IGradoviService
    {
        private readonly TravelEurope_Context _context;

        private readonly IMapper _mapper;

        public GradoviService(TravelEurope_Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Gradovi> Get(GradoviSearchRequest request)
        {
            var query = _context.Gradovi.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.Naziv.ToLower().Contains(request.Naziv.ToLower()));
            }
            if (request?.DrzavaId != 0)
            {
                query = query.Where(x => x.DrzavaId == request.DrzavaId);
            }

            query = query.Include(x => x.Drzava);

            var list = query.ToList();

            return _mapper.Map<List<Model.Gradovi>>(list);
        }

        public Model.Gradovi Insert(GradoviInsertRequest request)
        {
            Database.Gradovi entity = _mapper.Map<Database.Gradovi>(request);

            _context.Gradovi.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Gradovi>(entity);
        }

        public Model.Gradovi GetById(int id)
        {
            var query = _context.Gradovi.AsQueryable();

            query = query.Where(x => x.GradId == id);

            query = query.Include(x => x.Drzava);

            var entity = query.FirstOrDefault();

            return _mapper.Map<Model.Gradovi>(entity);
        }

        public Model.Gradovi Update(int id, GradoviInsertRequest request)
        {
            Database.Gradovi entity = _context.Gradovi.Where(x => x.GradId == id).FirstOrDefault();

            _context.Gradovi.Attach(entity);
            _context.Gradovi.Update(entity);

            entity = _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Gradovi>(entity);

        }

    }

}
