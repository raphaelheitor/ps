using PremierTest.Domain.Commands.Requests;
using PremierTest.Domain.Commands.Responses;

namespace PremierTest.Domain.Handlers.Interfaces
{
    public interface ICreateProjetoHandler
    {
        CreateUpdateProjetoResponse Handle(CreateProjetoRequest request);
    }
}
