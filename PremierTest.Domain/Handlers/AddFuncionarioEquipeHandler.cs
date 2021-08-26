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
        IFuncionarioEquipeRepository _funcionarioEquipeRepository;

        public AddFuncionarioEquipeHandler(IFuncionarioEquipeRepository funcionarioEquipeRepository)
        {
            _funcionarioEquipeRepository = funcionarioEquipeRepository;
        }
        public AddFuncionarioEquipeResponse Handle(AddFuncionarioEquipeRequest command)
        {
            var fe = _funcionarioEquipeRepository.Find(command.FuncionarioId, command.EquipeId);
            if (fe == null)
            {
                fe = _funcionarioEquipeRepository.Add(new FuncionarioEquipe(command.FuncionarioId, command.EquipeId));
                
                return new AddFuncionarioEquipeResponse
                {
                    Status = "Sucesso",
                    FuncionarioEquipe = fe
                };
            }
            else
                return new AddFuncionarioEquipeResponse
                {
                    Status = "Esse vínculo já existe na base de dados.",
                    FuncionarioEquipe = null
                };
        }
    }
}
