using PremierTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Domain.Interfaces
{
    public interface IEquipeRepository
    {
        IEnumerable<Equipe> GetEquipes();
        Equipe Get(int id);

    }
}
