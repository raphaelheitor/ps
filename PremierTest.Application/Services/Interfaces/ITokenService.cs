using PremierTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Application.Services.Interfaces
{
    public interface  ITokenService
    {
        string GenerateToken(Funcionario funcionario);
    }
}
