using PremierTest.Domain.Commands.Requests;
using PremierTest.Domain.Commands.Responses;
using PremierTest.Domain.Handlers.Interfaces;
using PremierTest.Domain.Entities;
using PremierTest.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using PremierTest.Domain.Queries.Requests;

namespace PremierTest.Domain.Handlers
{
    public class RemoveEquipeDeProjetoHandler : IRemoveEquipeDeProjetoHandler
    {
        IProjetoRepository _projetoRepository;
        IGetProjetoHandler _getProjetoHandler;

        public RemoveEquipeDeProjetoHandler(IProjetoRepository funcionarioEquipeRepository, IGetProjetoHandler getProjetoHandler)
        {
            _projetoRepository = funcionarioEquipeRepository;
            _getProjetoHandler = getProjetoHandler;
        }
        public AddRemoveEquipeDeProjetoResponse Handle(RemoveEquipeDeProjetoRequest command)
        {
            var responseProj = _getProjetoHandler.Handle(new GetProjetoRequest { ProjetoId = command.ProjetoId });
            if (responseProj.Projeto == null)
            {
                return new AddRemoveEquipeDeProjetoResponse
                {
                    Status = $"Não foi possível localizar Projeto id: {command.ProjetoId}.",
                    Projeto = null
                };
            }
            else if (responseProj.Projeto.Equipe == null)
            {
                return new AddRemoveEquipeDeProjetoResponse
                {
                    Status = $"O Projeto {responseProj.Projeto.Nome} não tem uma equipe vinculada",
                    Projeto = null
                };
            }
            var proj = responseProj.Projeto;
            proj.EquipeId = null;
            proj = _projetoRepository.RemoveEquipe(proj);
            return new AddRemoveEquipeDeProjetoResponse
            {
                Status = "Equipe removida do projeto.",
                Projeto = proj
            };
        }
    }
}
