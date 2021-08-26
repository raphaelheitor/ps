using PremierTest.Domain.Entities;


namespace PremierTest.Domain.Commands.Responses
{
    public class AddFuncionarioEquipeResponse
    {
        public string Status { get; set; }
        public FuncionarioEquipe FuncionarioEquipe { get; set; }
    }
}
