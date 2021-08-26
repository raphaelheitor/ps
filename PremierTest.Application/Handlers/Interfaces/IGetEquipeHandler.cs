using PremierTest.Application.Queries.Requests;
using PremierTest.Application.Queries.Responses;

namespace PremierTest.Application.Handlers.Interfaces
{
    public interface IGetEquipeHandler
    {
        GetEquipeResponse Handle(GetEquipeRequest command);
    }
}
