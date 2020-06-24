using AutoMapper;
using TravelEurope.Model.Requests;
using TravelEurope.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TravelEurope.WebAPI.Services
{
    public class PretplateService : IPretplateService
    {
        private readonly TravelEurope_Context _context;

        private readonly IMapper _mapper;

        public PretplateService(TravelEurope_Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public bool Remove(int id)
        {
            Database.Pretplate entity = _context.Pretplate.Where(x => x.KategorijaId == id && x.KorisnikId == 1).FirstOrDefault();
            if (entity != null)
            {
                _context.Pretplate.Remove(entity);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Model.Pretplate> Get(PretplateSearchRequest request)
        {
            var query = _context.Pretplate.AsQueryable();


            if (request?.KategorijaId != 0)
            {
                query = query.Where(x => x.KategorijaId == request.KategorijaId);
            }
            if (request?.KorisnikId != 0)
            {
                query = query.Where(x => x.KorisnikId == request.KorisnikId);
            }

            query = query.Include(x => x.Kategorija);
            query = query.Include(x => x.Korisnik);

            var list = query.ToList();

            return _mapper.Map<List<Model.Pretplate>>(list);
        }

        public Model.Pretplate GetById(int id)
        {
            var query = _context.Pretplate.AsQueryable();

            query = query.Where(x => x.PretplataId == id);

            query = query.Include(x => x.Kategorija);

            query = query.Include(x => x.Korisnik);


            var entity = query.FirstOrDefault();


            return _mapper.Map<Model.Pretplate>(entity);
        }

        public Model.Pretplate Insert(PretplateInsertRequest request)
        {
            Database.Pretplate entity = _mapper.Map<Database.Pretplate>(request);
            //entity.KorisnikId = Security.BasicAuthenticationHandler.PrijavljeniKorisnik.KorisniciId;

            _context.Pretplate.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Pretplate>(entity);
        }

        public Model.Pretplate Update(int id, PretplateInsertRequest request)
        {
            Database.Pretplate entity = _context.Pretplate.Where(x => x.PretplataId == id).FirstOrDefault();

            _context.Pretplate.Attach(entity);
            _context.Pretplate.Update(entity);

            entity = _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Pretplate>(entity);
        }
    }
}
