using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PremierTest.Domain.Commands.Requests;
using PremierTest.Domain.Commands.Responses;
using PremierTest.Domain.Handlers.Interfaces;
using PremierTest.Domain.Queries.Requests;
using PremierTest.Domain.Queries.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremierTest.Api.Controllers
{
    [ApiController]
    [Route("v1/projeto")]
    public class ProjetoController : ControllerBase
    {
        [HttpPost]
        [Route("criar")]
        [Authorize(Roles = "gestor")]
        public CreateUpdateProjetoResponse Criar(
            [FromServices] ICreateProjetoHandler handler,
            [FromBody] CreateProjetoRequest command
            )
        {
            return handler.Handle(command);
        }

        [HttpPut]
        [Route("atualizar")]
        [Authorize(Roles = "gestor")]
        public CreateUpdateProjetoResponse Atualizar(
            [FromServices] IUpdateProjetoHandler handler,
            [FromBody] UpdateProjetoRequest command
            )
        {
            return handler.Handle(command);
        }

        [HttpGet]
        [Route("todos")]
        [Authorize(Roles = "gestor")]
        public AllProjetosResponse Todos(
            [FromServices] IAllProjetosHandler handler
            )
        {
            return handler.Handle();
        }

        [HttpGet]
        [Route("porId/{ProjetoId}")]
        [Authorize(Roles = "gestor")]
        public GetProjetoResponse PorId(
            [FromServices] IGetProjetoHandler handler,
            [FromRoute] GetProjetoRequest command
            )
        {
            return handler.Handle(command);
        }

        [HttpPost]
        [Route("vincular")]
        [Authorize(Roles = "gestor")]
        public AddRemoveEquipeDeProjetoResponse DefinirEquipe(
            [FromServices] IAddEquipeAProjetoHandler handler,
            [FromBody] AddEquipeAProjetoRequest command
            )
        {
            return handler.Handle(command);
        }

        [HttpPost]
        [Route("remover-equipe")]
        [Authorize(Roles = "gestor")]
        public AddRemoveEquipeDeProjetoResponse RemoverEquipe(
            [FromServices] IRemoveEquipeDeProjetoHandler handler,
            [FromBody] RemoveEquipeDeProjetoRequest command
            )
        {
            return handler.Handle(command);
        }

        [HttpGet]
        [Route("horas/{ProjetoId}")]
        [Authorize(Roles = "gestor")]
        public GetHorasProjetoResponse Horas(
            [FromServices] IGetHorasProjetoHandler handler,
            [FromRoute] GetHorasProjetoRequest command
            )
        {
            return handler.Handle(command);
        }
    }
}
