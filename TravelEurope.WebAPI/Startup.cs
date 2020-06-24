using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using TravelEurope.WebAPI.Database;
using TravelEurope.WebAPI.Security;
using TravelEurope.WebAPI.Services;

namespace TravelEurope.WebAPI
{
    public class BasicAuthDocumentFilter : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            var securityRequirements = new Dictionary<string, IEnumerable<string>>()
        {
            { "basic", new string[] { } }  // in swagger you specify empty list unless using OAuth2 scopes
        };

            swaggerDoc.Security = new[] { securityRequirements };
        }
    }
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<IDrzaveService, DrzaveService>();
            services.AddScoped<IGradoviService, GradoviService>();
            services.AddScoped<ITuristRuteService, TuristRuteService>();
            services.AddScoped<ITuristickiVodiciService, TuristickiVodiciService>();
            services.AddScoped<IStraniJeziciService, StraniJeziciService>();
            services.AddScoped<IKategorijeService, KategorijeService>();
            services.AddScoped<IRuteSlikeService, RuteSlikeService>();
            services.AddScoped<IPretplateService, PretplateService>();
            services.AddScoped<IUlogeService, UlogeService>();
            services.AddScoped<ILokacijeService, LokacijeService>();
            services.AddScoped<IOcjeneService, OcjeneService>();
            services.AddScoped<IRezervacijeService, RezervacijeService>();
            services.AddScoped<IPreporukaService, PreporukaService>();
            services.AddScoped<IPorukeService, PorukeService>();

#pragma warning disable CS0618 // Type or member is obsolete
            services.AddAutoMapper();
            #pragma warning restore CS0618 // Type or member is obsolete

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "TravelEurope API v1", Version = "v1" });
                c.AddSecurityDefinition("basic", new BasicAuthScheme() { Type = "basic" });
                c.DocumentFilter<BasicAuthDocumentFilter>();
            });

            services.AddAuthentication("BasicAuthentication")
           .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            var connection = Configuration.GetConnectionString("LocalDB");

            services.AddDbContext<TravelEurope_Context>(options => options.UseSqlServer(connection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "TravelEurope V1");
            });

            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
