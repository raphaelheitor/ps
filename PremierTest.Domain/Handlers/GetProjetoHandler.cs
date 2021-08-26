using PremierTest.Domain.Handlers.Interfaces;
using PremierTest.Domain.Queries.Requests;
using PremierTest.Domain.Queries.Responses;
using PremierTest.Domain.Interfaces;

namespace PremierTest.Domain.Handlers
{
    public class GetProjetoHandler : IGetProjetoHandler
    {
        IProjetoRepository _projetoRepository;

        public GetProjetoHandler(IProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }
        public GetProjetoResponse Handle(GetProjetoRequest command)
        {
            var proj = _projetoRepository.Get(command.ProjetoId);
            if (proj != null)
            {
                return new GetProjetoResponse
                {
                    Status = "Sucesso",
                    Projeto = proj
                };
            }
            else
                return new GetProjetoResponse
                {
                    Status = "Projeto Não Localizado.",
                    Projeto = null
                };
        }
    }
}
