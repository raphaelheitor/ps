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
    public class AddEquipeAProjetoHandler : IAddEquipeAProjetoHandler
    {
        IProjetoRepository _projetoRepository;
        IGetProjetoHandler _getProjetoHandler;
        IGetEquipeHandler _getEquipeHandler;

        public AddEquipeAProjetoHandler(IProjetoRepository funcionarioEquipeRepository, IGetEquipeHandler getEquipeHandler, IGetProjetoHandler getProjetoHandler)
        {
            _projetoRepository = funcionarioEquipeRepository;
            _getEquipeHandler = getEquipeHandler;
            _getProjetoHandler = getProjetoHandler;
        }
        public AddRemoveEquipeDeProjetoResponse Handle(AddEquipeAProjetoRequest command)
        {
            var eq = _getEquipeHandler.Handle(new GetEquipeRequest { EquipeId = command.EquipeId });
            var responseProj = _getProjetoHandler.Handle(new GetProjetoRequest { ProjetoId = command.ProjetoId });
            if (eq.Equipe == null || responseProj.Projeto == null)
            {
                return new AddRemoveEquipeDeProjetoResponse
                {
                    Status = $"Não foi possível localizar Equipe id: {command.EquipeId} e/ou Projeto id: {command.ProjetoId}.",
                    Projeto = null
                };
            }
            else if (responseProj.Projeto.Equipe != null)
            {
                return new AddRemoveEquipeDeProjetoResponse
                {
                    Status = $"O Projeto {responseProj.Projeto.Nome} já tem uma equipe vinculada",
                    Projeto = null
                };
            }

            var proj = responseProj.Projeto;
            proj.EquipeId = command.EquipeId;
            proj = _projetoRepository.AddEquipe(proj);
            return new AddRemoveEquipeDeProjetoResponse
            {
                Status = "Equipe vinculada a projeto.",
                Projeto = proj
            };
        }
    }
}
