using PremierTest.Domain.Entities;
using System.Collections.Generic;

namespace PremierTest.Domain.Queries.Responses
{
    public class GetFuncionarioResponse
    {
        public string Status { get; set; }
        public Funcionario Funcionario { get; set; }
    }
}
