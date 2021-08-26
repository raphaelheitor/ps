using PremierTest.Domain.Entities;
using PremierTest.Domain.Interfaces;
using PremierTest.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PremierTest.Infra.Data.Repositories
{
    public class FuncionarioEquipeRepository : IFuncionarioEquipeRepository
    {
        private ApplicationDbContext _context;

        public FuncionarioEquipeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public FuncionarioEquipe Add(FuncionarioEquipe fe)
        {
            fe = _context.Add(fe).Entity;
            _context.SaveChanges();
            return fe;
        }
    }
}
