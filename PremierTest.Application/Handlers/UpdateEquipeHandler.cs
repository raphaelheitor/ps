using PremierTest.Application.Handlers.Interfaces;
using PremierTest.Domain.Interfaces;
using PremierTest.Application.Commands.Responses;
using PremierTest.Application.Commands.Requests;

namespace PremierTest.Application.Handlers
{
    public class UpdateEquipeHandler : IUpdateEquipeHandler
    {
        IEquipeRepository _equipeRepository;


        public UpdateEquipeHandler(IEquipeRepository equipeRepository)
        {
            _equipeRepository = equipeRepository;
        }
        public CreateUpdateEquipeResponse Handle(UpdateEquipeRequest request)
        {
            var eq = _equipeRepository.Update(request.Id, request.Nome);
            if (eq != null)
            {
                
                return new CreateUpdateEquipeResponse
                {
                    Status = $"Equipe {eq.Nome} atualizada.",
                    Id = eq.Id,
                    Equipe = eq
                };
            }
            else
                return new CreateUpdateEquipeResponse
                {
                    Status = $"Equipe de id: {request.Id} não localizada.",
                    Id = 0,
                    Equipe = null
                };

        }
    }
}
