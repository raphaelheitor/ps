using PremierTest.Application.Commands.Requests;
using PremierTest.Application.Commands.Responses;

namespace PremierTest.Application.Handlers.Interfaces
{
    public interface IAddFuncionarioEquipeHandler
    {
        AddFuncionarioEquipeResponse Handle(AddFuncionarioEquipeRequest command);
    }
}
