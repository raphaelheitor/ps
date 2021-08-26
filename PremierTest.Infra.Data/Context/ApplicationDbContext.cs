using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PremierTest.Domain.Entities;
using PremierTest.Infra.Data.EntityConfiguration;
using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Equipe> Equipes { get; set; }
        public DbSet<FuncionarioEquipe> FuncionarioEquipes { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<HoraTrabalhada> HoraTrabalhadas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new FuncionarioConfiguration());
            builder.ApplyConfiguration(new EquipeConfiguration());
            builder.ApplyConfiguration(new FuncionarioEquipeConfiguration());
            builder.ApplyConfiguration(new ProjetoConfiguration());
            builder.ApplyConfiguration(new HoraTrabalhadaConfiguration());

            builder.Entity<Funcionario>().HasData(new Funcionario
            {
                Id = 1,
                Nome = "Spider Man",
                Matricula = "12345",
                Password = "b7e94be513e96e8c45cd23d162275e5a12ebde9100a425c4ebcdd7fa4dcd897c", //pw = senha
                Perfil = "colaborador"
            }, new Funcionario
            {
                Id = 2,
                Nome = "Doctor Strange",
                Matricula = "54321",
                Password = "b7e94be513e96e8c45cd23d162275e5a12ebde9100a425c4ebcdd7fa4dcd897c", //pw = senha
                Perfil = "colaborador"
            }, new Funcionario
            {
                Id = 3,
                Nome = "Ironman",
                Matricula = "111",
                Password = "b7e94be513e96e8c45cd23d162275e5a12ebde9100a425c4ebcdd7fa4dcd897c", //pw = senha
                Perfil = "gestor"
            });

            builder.Entity<Equipe>().HasData(new Equipe()
            {
                Id = 1,
                Nome = "Avengers"
            });

            builder.Entity<Projeto>().HasData(new Projeto
            {
                Id = 1,
                Nome = "Infinite War"
            });
        }
    }
}
