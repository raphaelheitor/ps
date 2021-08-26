using PremierTest.Application.Handlers.Interfaces;
using PremierTest.Domain.Interfaces;
using PremierTest.Application.Commands.Responses;
using PremierTest.Application.Commands.Requests;
using PremierTest.Domain.Entities;

namespace PremierTest.Application.Handlers
{
    public class CreateEquipeHandler : ICreateEquipeHandler
    {
        IEquipeRepository _equipeRepository;


        public CreateEquipeHandler(IEquipeRepository equipeRepository)
        {
            _equipeRepository = equipeRepository;
        }
        public CreateUpdateEquipeResponse Handle(CreateEquipeRequest request)
        {
            var eq = _equipeRepository.Add(new Equipe(request.Nome));
            if (eq != null)
            {
                return new CreateUpdateEquipeResponse
                {
                    Status = "Equipe Criada",
                    Id = eq.Id,
                    Equipe = eq
                };
            }
            else
                return new CreateUpdateEquipeResponse
                {
                    Status = "Criação de Equipe Falhou",
                    Id = 0,
                    Equipe = null
                };

        }
    }
}
