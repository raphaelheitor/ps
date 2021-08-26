using Microsoft.EntityFrameworkCore;
using PremierTest.Domain.Entities;
using PremierTest.Domain.Interfaces;
using PremierTest.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PremierTest.Infra.Data.Repositories
{
    public class EquipeRepository : IEquipeRepository
    {
        private ApplicationDbContext _context;

        public EquipeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Equipe Add(Equipe equipe)
        {
            var eq = _context.Equipes.Add(equipe).Entity;
            _context.SaveChanges();
            return eq;
        }
        public Equipe Update(int Id, string Nome)
        {
            var eq = _context.Equipes.Find(Id);
            if (eq != null)
            {
                eq.SetNome(Nome);
                _context.Equipes.Update(eq);
                _context.SaveChanges();
                return eq;
            }
            return null;
        }

        public Equipe Get(int id)
        {
            return _context.Equipes.Include(e => e.FuncionarioEquipe).FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Equipe> GetAll()
        {
            return _context.Equipes;
        }
    }
}
