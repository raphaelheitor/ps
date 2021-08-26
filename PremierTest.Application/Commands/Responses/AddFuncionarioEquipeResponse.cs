using PremierTest.Domain.Entities;


namespace PremierTest.Application.Commands.Responses
{
    public class AddFuncionarioEquipeResponse
    {
        public string Status { get; set; }
        public FuncionarioEquipe FuncionarioEquipe { get; set; }
    }
}
