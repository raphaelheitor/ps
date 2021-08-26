using PremierTest.Domain.Handlers.Interfaces;
using PremierTest.Domain.Interfaces;
using PremierTest.Domain.Commands.Responses;
using PremierTest.Domain.Entities;
using PremierTest.Domain.Queries.Responses;

namespace PremierTest.Domain.Handlers
{
    public class AllProjetosHandler : IAllProjetosHandler
    {
        IProjetoRepository _projetoRepository;


        public AllProjetosHandler(IProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }
        public AllProjetosResponse Handle()
        {
            var projetos = _projetoRepository.GetAll();
            return new AllProjetosResponse
            {
                Status = "Sucesso",
                Projetos = projetos
            };

        }
    }
}
