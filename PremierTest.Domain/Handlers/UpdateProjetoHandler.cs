using PremierTest.Domain.Handlers.Interfaces;
using PremierTest.Domain.Interfaces;
using PremierTest.Domain.Commands.Responses;
using PremierTest.Domain.Commands.Requests;

namespace PremierTest.Domain.Handlers
{
    public class UpdateProjetoHandler : IUpdateProjetoHandler
    {
        IProjetoRepository _projetoRepository;


        public UpdateProjetoHandler(IProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }
        public CreateUpdateProjetoResponse Handle(UpdateProjetoRequest request)
        {
            var proj = _projetoRepository.Update(request.Id, request.Nome);
            if (proj != null)
            {
                
                return new CreateUpdateProjetoResponse
                {
                    Status = $"Projeto {proj.Nome} atualizado.",
                    Id = proj.Id,
                    Projeto = proj
                };
            }
            else
                return new CreateUpdateProjetoResponse
                {
                    Status = $"Projeto de id: {request.Id} não localizado.",
                    Id = 0,
                    Projeto = null
                };

        }
    }
}
