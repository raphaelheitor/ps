using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using PremierTest.Domain.Handlers;
using PremierTest.Domain.Handlers.Interfaces;
using PremierTest.Domain.Services;
using PremierTest.Domain.Services.Interfaces;
using PremierTest.Domain.Interfaces;
using PremierTest.Infra.Data.Context;
using PremierTest.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            string appSettingKey = configuration.GetSection("SecretKey").Value;
            //Login Handlers DI
            services.AddTransient<ILoginHandler, LoginHandler>();
            //Funcionario Handlers DI
            services.AddTransient<IGetFuncionarioHandler, GetFuncionarioHandler>();
            //Equipe Handlers DI
            services.AddTransient<ICreateEquipeHandler, CreateEquipeHandler>();
            services.AddTransient<IAllEquipesHandler, AllEquipesHandler>();
            services.AddTransient<IGetEquipeHandler, GetEquipeHandler>();
            services.AddTransient<IAddFuncionarioEquipeHandler, AddFuncionarioEquipeHandler>();
            services.AddTransient<IUpdateEquipeHandler, UpdateEquipeHandler>();
            //Projeto Handlers DI
            services.AddTransient<ICreateProjetoHandler, CreateProjetoHandler>();
            services.AddTransient<IUpdateProjetoHandler, UpdateProjetoHandler>();
            services.AddTransient<IAllProjetosHandler, AllProjetosHandler>();
            services.AddTransient<IGetProjetoHandler, GetProjetoHandler>();
            services.AddTransient<IAddEquipeAProjetoHandler, AddEquipeAProjetoHandler>();
            services.AddTransient<IRemoveEquipeDeProjetoHandler, RemoveEquipeDeProjetoHandler>();
            services.AddTransient<IGetHorasProjetoHandler, GetHorasProjetoHandler>();
            //HoraTrabalhada Handlers DI
            services.AddTransient<IInformarHoraHandler, InformarHoraHandler>();
            //Service DI
            services.AddScoped<ITokenService>(t => new TokenService(appSettingKey));
            //Repository DI
            services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();
            services.AddScoped<IEquipeRepository, EquipeRepository>();
            services.AddScoped<IFuncionarioEquipeRepository, FuncionarioEquipeRepository>();
            services.AddScoped<IProjetoRepository, ProjetoRepository>();
            services.AddScoped<IHoraTrabalhadaRepository, HoraTrabalhadaRepository>();

            var key = Encoding.ASCII.GetBytes(appSettingKey);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            return services;
        }
    }
}
