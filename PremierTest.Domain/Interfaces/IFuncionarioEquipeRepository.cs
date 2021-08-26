using PremierTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Domain.Interfaces
{
    public interface IFuncionarioEquipeRepository
    {
        FuncionarioEquipe Add(FuncionarioEquipe fe);
        FuncionarioEquipe Find(int FuncionarioId, int EquipeId);
    }
}
