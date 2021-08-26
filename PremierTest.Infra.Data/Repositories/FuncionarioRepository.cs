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
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private ApplicationDbContext _context;

        public FuncionarioRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Funcionario Get(int id)
        {
            return _context.Funcionarios.Include(f => f.FuncionarioEquipe).Where(f => f.Id == id).FirstOrDefault();
        }

        public Funcionario Login(string matricula, string password)
        {
            return _context.Funcionarios.Where(f => f.Matricula == matricula && f.Password == password).FirstOrDefault();
        }
    }
}
