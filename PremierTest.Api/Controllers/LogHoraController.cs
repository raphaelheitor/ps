using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PremierTest.Domain.Commands.Requests;
using PremierTest.Domain.Commands.Responses;
using PremierTest.Domain.Handlers.Interfaces;

namespace PremierTest.Api.Controllers
{
    [ApiController]
    [Route("v1/log-hora")]
    public class LogHoraController : ControllerBase
    {
        [HttpPost]
        [Route("registar")]
        [Authorize]
        public InformarHoraResponse Registrar(
            [FromServices] IInformarHoraHandler handler,
            [FromBody] InformarHoraRequest command
            )
        {
            return handler.Handle(command);
        }
    }
}
