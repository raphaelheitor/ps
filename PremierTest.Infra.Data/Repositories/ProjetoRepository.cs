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
    public class ProjetoRepository : IProjetoRepository
    {
        private ApplicationDbContext _context;

        public ProjetoRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Projeto Add(Projeto projeto)
        {
            var proj = _context.Projetos.Add(projeto).Entity;
            _context.SaveChanges();
            return proj;
        }
        public Projeto AddEquipe(Projeto projeto)
        {
            var proj = _context.Projetos.Update(projeto).Entity;
            _context.SaveChanges();
            return proj;
        }
        public Projeto RemoveEquipe(Projeto projeto)
        {
            var proj = _context.Projetos.Update(projeto).Entity;
            _context.SaveChanges();
            return proj;
        }
        public Projeto Update(int Id, string Nome)
        {
            var proj = _context.Projetos.Find(Id);
            if (proj != null)
            {
                proj.SetNome(Nome);
                _context.Projetos.Update(proj);
                _context.SaveChanges();
                return proj;
            }
            return null;
        }

        public Projeto Get(int id)
        {
            return _context.Projetos.Include(e => e.Equipe).FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Projeto> GetAll()
        {
            return _context.Projetos;
        }
    }
}
