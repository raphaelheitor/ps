using PremierTest.Domain.Commands.Requests;
using PremierTest.Domain.Commands.Responses;

namespace PremierTest.Domain.Handlers.Interfaces
{
    public interface ICreateEquipeHandler
    {
        CreateUpdateEquipeResponse Handle(CreateEquipeRequest request);
    }
}
