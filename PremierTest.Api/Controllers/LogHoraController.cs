using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PremierTest.Application.Commands.Requests;
using PremierTest.Application.Commands.Responses;
using PremierTest.Application.Handlers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremierTest.Api.Controllers
{
    [ApiController]
    [Route("v1/log-hora")]
    public class LogHoraController : ControllerBase
    {
        [HttpGet]
        [Route("teste/auth")]
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
