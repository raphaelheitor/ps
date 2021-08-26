using PremierTest.Domain.Entities;
using System.Collections.Generic;

namespace PremierTest.Domain.Queries.Responses
{
    public class GetProjetoResponse
    {
        public string Status { get; set; }
        public Projeto Projeto { get; set; }
    }
}
