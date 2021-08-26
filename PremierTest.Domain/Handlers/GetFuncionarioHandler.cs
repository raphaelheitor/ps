using PremierTest.Domain.Handlers.Interfaces;
using PremierTest.Domain.Queries.Requests;
using PremierTest.Domain.Queries.Responses;
using PremierTest.Domain.Interfaces;

namespace PremierTest.Domain.Handlers
{
    public class GetFuncionarioHandler : IGetFuncionarioHandler
    {
        IFuncionarioRepository _funcionarioRepository;

        public GetFuncionarioHandler(IFuncionarioRepository equipeRepository)
        {
            _funcionarioRepository = equipeRepository;
        }
        public GetFuncionarioResponse Handle(GetFuncionarioRequest command)
        {
            var funcionario = _funcionarioRepository.Get(command.FuncionarioId);
            if (funcionario != null)
            {
                return new GetFuncionarioResponse
                {
                    Status = "Sucesso",
                    Funcionario = funcionario
                };
            }
            else
                return new GetFuncionarioResponse
                {
                    Status = "Funcionário Não Localizado.",
                    Funcionario = null
                };
        }
    }
}
