using PremierTest.Domain.Entities;
using System.Collections.Generic;

namespace PremierTest.Application.Queries.Responses
{
    public class GetEquipeResponse
    {
        public string Status { get; set; }
        public Equipe Equipe { get; set; }
    }
}
