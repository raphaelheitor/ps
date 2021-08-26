using PremierTest.Domain.Entities;
using System.Collections.Generic;

namespace PremierTest.Domain.Queries.Responses
{
    public class AllEquipesResponse
    {
        public string Status { get; set; }
        public IEnumerable<Equipe> Equipes { get; set; }
    }
}
