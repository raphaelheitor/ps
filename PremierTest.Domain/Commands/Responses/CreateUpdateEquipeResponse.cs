using PremierTest.Domain.Entities;

namespace PremierTest.Domain.Commands.Responses
{
    public class CreateUpdateEquipeResponse
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public Equipe Equipe { get; set; }
    }
}
