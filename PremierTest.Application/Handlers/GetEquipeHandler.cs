using PremierTest.Application.Handlers.Interfaces;
using PremierTest.Application.Queries.Requests;
using PremierTest.Application.Queries.Responses;
using PremierTest.Domain.Interfaces;

namespace PremierTest.Application.Handlers
{
    public class GetEquipeHandler : IGetEquipeHandler
    {
        IEquipeRepository _equipeRepository;

        public GetEquipeHandler(IEquipeRepository equipeRepository)
        {
            _equipeRepository = equipeRepository;
        }
        public GetEquipeResponse Handle(GetEquipeRequest command)
        {
            var equipe = _equipeRepository.Get(command.EquipeId);
            if (equipe != null)
            {
                return new GetEquipeResponse
                {
                    Status = "Sucesso",
                    Equipe = equipe
                };
            }
            else
                return new GetEquipeResponse
                {
                    Status = "Equipe Não Localizada.",
                    Equipe = null
                };
        }
    }
}
