using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TravelEurope.WebAPI.Database
{
    public partial class TravelEurope_Context : DbContext
    {
 
        public TravelEurope_Context(DbContextOptions<TravelEurope_Context> options)
            : base(options)
        {
        }
        public TravelEurope_Context()
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer(@"Server=.;Database=TravelEurope_RS2-3;Trusted_Connection=True;ConnectRetryCount=0");
        //    }
        //}


        public virtual DbSet<Drzave> Drzave { get; set; }
        public virtual DbSet<Gradovi> Gradovi { get; set; }
        public virtual DbSet<Kategorije> Kategorije { get; set; }
        public virtual DbSet<Korisnici> Korisnici { get; set; }
        public virtual DbSet<Lokacije> Lokacije { get; set; }
        public virtual DbSet<Ocjene> Ocjene { get; set; }
        public virtual DbSet<Poruke> Poruke { get; set; }
        public virtual DbSet<Pretplate> Pretplate { get; set; }
        public virtual DbSet<Rezervacije> Rezervacije { get; set; }
        public virtual DbSet<RuteSlike> RuteSlike { get; set; }
        public virtual DbSet<StraniJezici> StraniJezici { get; set; }
        public virtual DbSet<TuristickiVodici> TuristickiVodici { get; set; }
        public virtual DbSet<TuristRute> TuristRute { get; set; }
        public virtual DbSet<Uloge> Uloge { get; set; }
    }
}