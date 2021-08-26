using PremierTest.Domain.Handlers.Interfaces;
using PremierTest.Domain.Queries.Requests;
using PremierTest.Domain.Queries.Responses;
using PremierTest.Domain.Interfaces;

namespace PremierTest.Domain.Handlers
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
