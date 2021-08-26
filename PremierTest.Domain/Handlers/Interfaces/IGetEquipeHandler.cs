using PremierTest.Domain.Queries.Requests;
using PremierTest.Domain.Queries.Responses;

namespace PremierTest.Domain.Handlers.Interfaces
{
    public interface IGetEquipeHandler
    {
        GetEquipeResponse Handle(GetEquipeRequest command);
    }
}
