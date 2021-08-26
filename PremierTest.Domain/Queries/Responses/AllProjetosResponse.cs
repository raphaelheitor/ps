using PremierTest.Domain.Entities;
using System.Collections.Generic;

namespace PremierTest.Domain.Queries.Responses
{
    public class AllProjetosResponse
    {
        public string Status { get; set; }
        public IEnumerable<Projeto> Projetos { get; set; }
    }
}
