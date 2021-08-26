using PremierTest.Domain.Commands.Requests;
using PremierTest.Domain.Commands.Responses;
using PremierTest.Domain.Handlers.Interfaces;
using PremierTest.Domain.Entities;
using PremierTest.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Domain.Handlers
{
    public class AddFuncionarioEquipeHandler : IAddFuncionarioEquipeHandler
    {
        IGetEquipeHandler _getEquipeHandler;
        IFuncionarioEquipeRepository _funcionarioEquipeRepository;

        public AddFuncionarioEquipeHandler(IFuncionarioEquipeRepository funcionarioEquipeRepository, IGetEquipeHandler getEquipeHandler)
        {
            _funcionarioEquipeRepository = funcionarioEquipeRepository;
            _getEquipeHandler = getEquipeHandler;
        }
        public AddFuncionarioEquipeResponse Handle(AddFuncionarioEquipeRequest command)
        {
            var fe = _funcionarioEquipeRepository.Add(new FuncionarioEquipe(command.FuncionarioId, command.EquipeId));
            if (fe != null)
            {
                return new AddFuncionarioEquipeResponse
                {
                    Status = "Sucesso",
                    FuncionarioEquipe = fe
                };
            }
            else
                return new AddFuncionarioEquipeResponse
                {
                    Status = "Nào foi possível vincular funcionário na equipe.",
                    FuncionarioEquipe = null
                };
        }
    }
}
