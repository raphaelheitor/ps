using PremierTest.Domain.Commands.Requests;
using PremierTest.Domain.Commands.Responses;
using PremierTest.Domain.Handlers.Interfaces;
using PremierTest.Domain.Queries.Requests;
using PremierTest.Domain.Interfaces;
using PremierTest.Domain.Entities;
using System.Linq;

namespace PremierTest.Domain.Handlers
{
    public class InformarHoraHandler : IInformarHoraHandler
    {
        IGetProjetoHandler _getProjetoHandler;
        IGetFuncionarioHandler _getFuncionarioHandler;
        IHoraTrabalhadaRepository _horaTrabalhadaRepository;
        public InformarHoraHandler(IHoraTrabalhadaRepository horaTrabalhadaRepository, IGetProjetoHandler getProjetoHandler, IGetFuncionarioHandler getFuncionarioHandler)
        {
            _horaTrabalhadaRepository = horaTrabalhadaRepository;
            _getProjetoHandler = getProjetoHandler;
            _getFuncionarioHandler = getFuncionarioHandler;
        }
        public InformarHoraResponse Handle(InformarHoraRequest request)
        {
            var responseFunc = _getFuncionarioHandler.Handle(new GetFuncionarioRequest { FuncionarioId = request.FuncionarioId });
            var responseProj = _getProjetoHandler.Handle(new GetProjetoRequest { ProjetoId = request.ProjetoId });
            if (responseFunc.Funcionario == null  || responseProj.Projeto == null)
            {
                return new InformarHoraResponse
                {
                    HoraTrabalhada = null,
                    Id = 0,
                    Status = $"Não foi possível localizar o Projeto id: {request.ProjetoId} e/ou o Funcionario id: {request.FuncionarioId}"
                };
            }
            else if (responseProj.Projeto.Equipe == null)
            {
                return new InformarHoraResponse
                {
                    HoraTrabalhada = null,
                    Id = 0,
                    Status = $"O Projeto id: {request.ProjetoId} não tem equipe vinculada"
                };
            }
            else if (!responseFunc.Funcionario.FuncionarioEquipe.Where(f => f.EquipeId == responseProj.Projeto.EquipeId).Any())
            {
                return new InformarHoraResponse
                {
                    HoraTrabalhada = null,
                    Id = 0,
                    Status = $"O Colaborador {responseFunc.Funcionario.Nome} não pertence a essa equipe."
                };
            }

            var ht = _horaTrabalhadaRepository.InformarHora(new HoraTrabalhada(request.FuncionarioId, request.ProjetoId, request.HorasTrabalhadas));
            //ToDo Trabalhar com DTO para evitar isso
            ht.Colaborador = null;
            ht.Projeto = null;
            return new InformarHoraResponse {
                HoraTrabalhada = ht,
                Id = ht.Id,
                Status = "Hora Registrada Com Sucesso."
            };
            
        
        }
    }
}
