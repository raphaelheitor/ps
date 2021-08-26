using PremierTest.Domain.Entities;
using System.Collections.Generic;

namespace PremierTest.Domain.Interfaces
{
    public interface IEquipeRepository
    {
        /// <summary>
        /// Commands
        /// </summary>
        /// <returns></returns>
        Equipe Add(Equipe funcionario);
        Equipe Update(int Id, string Nome);

        /// <summary>
        /// Queries
        /// </summary>
        /// <returns></returns>
        IEnumerable<Equipe> GetAll();
        Equipe Get(int id);
    }
}
