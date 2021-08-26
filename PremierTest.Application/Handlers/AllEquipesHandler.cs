using PremierTest.Application.Handlers.Interfaces;
using PremierTest.Domain.Interfaces;
using PremierTest.Application.Commands.Responses;
using PremierTest.Domain.Entities;
using PremierTest.Application.Queries.Responses;

namespace PremierTest.Application.Handlers
{
    public class AllEquipesHandler : IAllEquipesHandler
    {
        IEquipeRepository _equipeRepository;


        public AllEquipesHandler(IEquipeRepository equipeRepository)
        {
            _equipeRepository = equipeRepository;
        }
        public AllEquipesResponse Handle()
        {
            var equipes = _equipeRepository.GetAll();
            return new AllEquipesResponse
            {
                Status = "Sucesso",
                Equipes = equipes
            };

        }
    }
}
