using PremierTest.Domain.Entities;
using System.Collections.Generic;

namespace PremierTest.Domain.Interfaces
{
    public interface IProjetoRepository
    {
        /// <summary>
        /// Commands
        /// </summary>
        /// <returns></returns>
        Projeto Add(Projeto projeto);
        Projeto AddEquipe(Projeto projeto);
        Projeto Update(int Id, string Nome);
        Projeto RemoveEquipe(Projeto projeto);

        /// <summary>
        /// Queries
        /// </summary>
        /// <returns></returns>
        IEnumerable<Projeto> GetAll();
        Projeto Get(int id);
        Projeto GetWithList(int id);
    }
}
