﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelEurope.WebAPI.Database;

namespace TravelEurope.WebAPI.Migrations
{
    [DbContext(typeof(TravelEurope_Context))]
    [Migration("20200308050621_OcjeneReset2")]
    partial class OcjeneReset2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Drzave", b =>
                {
                    b.Property<int>("DrzavaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("DrzavaId");

                    b.ToTable("Drzave");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Gradovi", b =>
                {
                    b.Property<int>("GradId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DrzavaId");

                    b.Property<string>("Naziv");

                    b.HasKey("GradId");

                    b.HasIndex("DrzavaId");

                    b.ToTable("Gradovi");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Kategorije", b =>
                {
                    b.Property<int>("KategorijaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("KategorijaId");

                    b.ToTable("Kategorije");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Korisnici", b =>
                {
                    b.Property<int>("KorisniciId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<int>("GradId");

                    b.Property<string>("Ime");

                    b.Property<string>("KorisnickoIme");

                    b.Property<string>("LozinkaHash");

                    b.Property<string>("LozinkaSalt");

                    b.Property<string>("Prezime");

                    b.Property<byte[]>("Slika");

                    b.Property<bool>("Status");

                    b.Property<int>("UlogaId");

                    b.Property<DateTime>("ZadnjaAktivnost");

                    b.HasKey("KorisniciId");

                    b.HasIndex("GradId");

                    b.HasIndex("UlogaId");

                    b.ToTable("Korisnici");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Lokacije", b =>
                {
                    b.Property<int>("LokacijaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DrzavaId");

                    b.Property<string>("Naziv");

                    b.HasKey("LokacijaId");

                    b.HasIndex("DrzavaId");

                    b.ToTable("Lokacije");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Ocjene", b =>
                {
                    b.Property<int>("OcjenaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumOcjene");

                    b.Property<string>("Komentar");

                    b.Property<int>("KorisnikId");

                    b.Property<int>("Ocjena");

                    b.Property<int>("RezervacijaId");

                    b.HasKey("OcjenaId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("RezervacijaId");

                    b.ToTable("Ocjene");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Poruke", b =>
                {
                    b.Property<int>("PorukaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumVrijeme");

                    b.Property<int>("PosiljalacId");

                    b.Property<int>("PrimalacId");

                    b.Property<string>("Sadrzaj");

                    b.HasKey("PorukaId");

                    b.HasIndex("PosiljalacId");

                    b.HasIndex("PrimalacId");

                    b.ToTable("Poruke");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Pretplate", b =>
                {
                    b.Property<int>("PretplataId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KategorijaId");

                    b.Property<int>("KorisnikId");

                    b.HasKey("PretplataId");

                    b.HasIndex("KategorijaId");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Pretplate");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Rezervacije", b =>
                {
                    b.Property<int>("RezervacijaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumRezervacije");

                    b.Property<int>("KorisnikId");

                    b.Property<int>("TuristRutaId");

                    b.HasKey("RezervacijaId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("TuristRutaId");

                    b.ToTable("Rezervacije");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.RuteSlike", b =>
                {
                    b.Property<int>("RuteSlikeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Opis");

                    b.Property<byte[]>("Slika");

                    b.Property<byte[]>("SlikaThumb");

                    b.Property<int>("TuristRutaId");

                    b.HasKey("RuteSlikeId");

                    b.HasIndex("TuristRutaId");

                    b.ToTable("RuteSlike");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.StraniJezici", b =>
                {
                    b.Property<int>("StraniJezikId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("StraniJezikId");

                    b.ToTable("StraniJezici");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.TuristickiVodici", b =>
                {
                    b.Property<int>("TuristickiVodicId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

                    b.Property<int>("StraniJezikId");

                    b.HasKey("TuristickiVodicId");

                    b.HasIndex("StraniJezikId");

                    b.ToTable("TuristickiVodici");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.TuristRute", b =>
                {
                    b.Property<int>("TuristRutaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("CijenaOsiguranja");

                    b.Property<decimal>("CijenaPaketa");

                    b.Property<DateTime>("DatumPutovanja");

                    b.Property<int>("KategorijaId");

                    b.Property<int>("LokacijaId");

                    b.Property<string>("Naziv");

                    b.Property<string>("Opis");

                    b.Property<int>("TrajanjePutovanja");

                    b.Property<int>("TuristickiVodicId");

                    b.HasKey("TuristRutaId");

                    b.HasIndex("KategorijaId");

                    b.HasIndex("LokacijaId");

                    b.HasIndex("TuristickiVodicId");

                    b.ToTable("TuristRute");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Uloge", b =>
                {
                    b.Property<int>("UlogaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.Property<string>("Opis");

                    b.HasKey("UlogaId");

                    b.ToTable("Uloge");
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Gradovi", b =>
                {
                    b.HasOne("TravelEurope.WebAPI.Database.Drzave", "Drzava")
                        .WithMany()
                        .HasForeignKey("DrzavaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Korisnici", b =>
                {
                    b.HasOne("TravelEurope.WebAPI.Database.Gradovi", "Grad")
                        .WithMany()
                        .HasForeignKey("GradId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TravelEurope.WebAPI.Database.Uloge", "Uloga")
                        .WithMany()
                        .HasForeignKey("UlogaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Lokacije", b =>
                {
                    b.HasOne("TravelEurope.WebAPI.Database.Drzave", "Drzava")
                        .WithMany()
                        .HasForeignKey("DrzavaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Ocjene", b =>
                {
                    b.HasOne("TravelEurope.WebAPI.Database.Korisnici", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TravelEurope.WebAPI.Database.Rezervacije", "Rezervacija")
                        .WithMany()
                        .HasForeignKey("RezervacijaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Poruke", b =>
                {
                    b.HasOne("TravelEurope.WebAPI.Database.Korisnici", "Posiljalac")
                        .WithMany()
                        .HasForeignKey("PosiljalacId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TravelEurope.WebAPI.Database.Korisnici", "Primalac")
                        .WithMany()
                        .HasForeignKey("PrimalacId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Pretplate", b =>
                {
                    b.HasOne("TravelEurope.WebAPI.Database.Kategorije", "Kategorija")
                        .WithMany()
                        .HasForeignKey("KategorijaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TravelEurope.WebAPI.Database.Korisnici", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.Rezervacije", b =>
                {
                    b.HasOne("TravelEurope.WebAPI.Database.Korisnici", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TravelEurope.WebAPI.Database.TuristRute", "TuristRuta")
                        .WithMany()
                        .HasForeignKey("TuristRutaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.RuteSlike", b =>
                {
                    b.HasOne("TravelEurope.WebAPI.Database.TuristRute", "TuristRuta")
                        .WithMany("RuteSlike")
                        .HasForeignKey("TuristRutaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.TuristickiVodici", b =>
                {
                    b.HasOne("TravelEurope.WebAPI.Database.StraniJezici", "StraniJezik")
                        .WithMany()
                        .HasForeignKey("StraniJezikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TravelEurope.WebAPI.Database.TuristRute", b =>
                {
                    b.HasOne("TravelEurope.WebAPI.Database.Kategorije", "Kategorija")
                        .WithMany()
                        .HasForeignKey("KategorijaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TravelEurope.WebAPI.Database.Lokacije", "Lokacija")
                        .WithMany()
                        .HasForeignKey("LokacijaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TravelEurope.WebAPI.Database.TuristickiVodici", "TuristickiVodic")
                        .WithMany()
                        .HasForeignKey("TuristickiVodicId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
