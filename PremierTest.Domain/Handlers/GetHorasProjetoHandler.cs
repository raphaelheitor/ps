using PremierTest.Domain.Handlers.Interfaces;
using PremierTest.Domain.Queries.Requests;
using PremierTest.Domain.Queries.Responses;
using PremierTest.Domain.Interfaces;
using System.Linq;

namespace PremierTest.Domain.Handlers
{
    public class GetHorasProjetoHandler : IGetHorasProjetoHandler
    {
        IProjetoRepository _projetoRepository;

        public GetHorasProjetoHandler(IProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        public GetHorasProjetoResponse Handle(GetHorasProjetoRequest command)
        {
            var requestProj = _projetoRepository.GetWithList(command.ProjetoId);
            if (requestProj != null)
            {
                return new GetHorasProjetoResponse
                {
                    ProjetoNome = requestProj.Nome,
                    Status = "Sucesso.",
                    TotalHoras = requestProj.HorasTrabalhadas.Count() != 0 ? requestProj.HorasTrabalhadas.Sum(ht => ht.Horas) : 0
                };
            }
            return new GetHorasProjetoResponse
            {
                ProjetoNome = "",
                TotalHoras = 0,
                Status = $"Projeto id: {command.ProjetoId} não localizado"
            };
        }
    }
}
