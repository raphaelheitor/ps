using PremierTest.Domain.Handlers.Interfaces;
using PremierTest.Domain.Interfaces;
using PremierTest.Domain.Commands.Responses;
using PremierTest.Domain.Commands.Requests;
using PremierTest.Domain.Entities;

namespace PremierTest.Domain.Handlers
{
    public class CreateProjetoHandler : ICreateProjetoHandler
    {
        IProjetoRepository _projetoRepository;


        public CreateProjetoHandler(IProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }
        public CreateUpdateProjetoResponse Handle(CreateProjetoRequest request)
        {
            var proj = _projetoRepository.Add(new Projeto(request.Nome));
            if (proj != null)
            {
                return new CreateUpdateProjetoResponse
                {
                    Status = "Projeto Criado.",
                    Id = proj.Id,
                    Projeto = proj
                };
            }
            else
                return new CreateUpdateProjetoResponse
                {
                    Status = "Criação de Projeto Falhou.",
                    Id = 0,
                    Projeto = null
                };

        }
    }
}
