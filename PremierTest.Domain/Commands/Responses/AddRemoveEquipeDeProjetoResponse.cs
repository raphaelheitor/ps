using PremierTest.Domain.Entities;


namespace PremierTest.Domain.Commands.Responses
{
    public class AddRemoveEquipeDeProjetoResponse
    {
        public string Status { get; set; }
        public Projeto Projeto { get; set; }
    }
}
