using PremierTest.Domain.Handlers.Interfaces;
using PremierTest.Domain.Interfaces;
using PremierTest.Domain.Commands.Responses;
using PremierTest.Domain.Entities;
using PremierTest.Domain.Queries.Responses;

namespace PremierTest.Domain.Handlers
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
