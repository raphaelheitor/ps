using PremierTest.Domain.Entities;
using System.Collections.Generic;

namespace PremierTest.Domain.Queries.Responses
{
    public class GetHorasProjetoResponse
    {
        public string Status { get; set; }
        public string ProjetoNome { get; set; }
        public decimal TotalHoras { get; set; }
    }
}
