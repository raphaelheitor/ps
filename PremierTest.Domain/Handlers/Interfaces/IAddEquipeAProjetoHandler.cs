using PremierTest.Domain.Commands.Requests;
using PremierTest.Domain.Commands.Responses;

namespace PremierTest.Domain.Handlers.Interfaces
{
    public interface IAddEquipeAProjetoHandler
    {
        AddRemoveEquipeDeProjetoResponse Handle(AddEquipeAProjetoRequest command);
    }
}
