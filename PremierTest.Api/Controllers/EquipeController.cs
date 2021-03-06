using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PremierTest.Domain.Commands.Requests;
using PremierTest.Domain.Commands.Responses;
using PremierTest.Domain.Handlers.Interfaces;
using PremierTest.Domain.Queries.Requests;
using PremierTest.Domain.Queries.Responses;

namespace PremierTest.Api.Controllers
{
    [ApiController]
    [Route("v1/equipe")]
    public class EquipeController : ControllerBase
    {
        [HttpPost]
        [Route("criar")]
        [Authorize(Roles = "gestor")]
        public CreateUpdateEquipeResponse Criar(
            [FromServices] ICreateEquipeHandler handler,
            [FromBody] CreateEquipeRequest command
            )
        {
            return handler.Handle(command);
        }

        [HttpPut]
        [Route("atualizar")]
        [Authorize(Roles = "gestor")]
        public CreateUpdateEquipeResponse Atualizar(
            [FromServices] IUpdateEquipeHandler handler,
            [FromBody] UpdateEquipeRequest command
            )
        {
            return handler.Handle(command);
        }

        [HttpGet]
        [Route("todas")]
        [Authorize(Roles = "gestor")]
        public AllEquipesResponse Todas(
            [FromServices] IAllEquipesHandler handler
            )
        {
            return handler.Handle();
        }

        [HttpGet]
        [Route("porId/{EquipeId}")]
        [Authorize(Roles = "gestor")]
        public GetEquipeResponse PorId(
            [FromServices] IGetEquipeHandler handler,
            [FromRoute] GetEquipeRequest command
            )
        {
            return handler.Handle(command);
        }

        [HttpPost]
        [Route("vincular")]
        [Authorize(Roles = "gestor")]
        public AddFuncionarioEquipeResponse VincularFuncionario(
            [FromServices] IAddFuncionarioEquipeHandler handler,
            [FromBody] AddFuncionarioEquipeRequest command
            )
        {
            return handler.Handle(command);
        }
    }
}
