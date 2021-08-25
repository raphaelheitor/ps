using PremierTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Domain.Interfaces
{
    public interface IFuncionarioRepository
    {
        Funcionario Login(string matricula, string password);
        Funcionario Get(int id);
    }
}
