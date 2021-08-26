using PremierTest.Domain.Entities;

namespace PremierTest.Domain.Commands.Responses
{
    public class CreateUpdateProjetoResponse
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public Projeto Projeto { get; set; }
    }
}
