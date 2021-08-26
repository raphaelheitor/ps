using PremierTest.Domain.Entities;

namespace PremierTest.Application.Commands.Responses
{
    public class CreateUpdateEquipeResponse
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public Equipe Equipe { get; set; }
    }
}
