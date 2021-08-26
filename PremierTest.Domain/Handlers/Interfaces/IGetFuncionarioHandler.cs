using PremierTest.Domain.Queries.Requests;
using PremierTest.Domain.Queries.Responses;

namespace PremierTest.Domain.Handlers.Interfaces
{
    public interface IGetFuncionarioHandler
    {
        GetFuncionarioResponse Handle(GetFuncionarioRequest command);
    }
}
