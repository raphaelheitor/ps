using PremierTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Domain.Services.Interfaces
{
    public interface  ITokenService
    {
        string GenerateToken(Funcionario funcionario);
    }
}
