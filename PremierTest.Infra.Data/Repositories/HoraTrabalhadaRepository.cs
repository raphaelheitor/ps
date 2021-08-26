using PremierTest.Domain.Entities;
using PremierTest.Domain.Interfaces;
using PremierTest.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Infra.Data.Repositories
{
    public class HoraTrabalhadaRepository : IHoraTrabalhadaRepository
    {
        private ApplicationDbContext _context;

        public HoraTrabalhadaRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public HoraTrabalhada InformarHora(HoraTrabalhada horaTrabalhada)
        {
            var ht = _context.HoraTrabalhadas.Add(horaTrabalhada).Entity;
            _context.SaveChanges();
            return ht;
        }
    }
}
