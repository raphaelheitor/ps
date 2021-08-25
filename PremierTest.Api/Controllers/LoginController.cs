using Microsoft.AspNetCore.Mvc;
using PremierTest.Domain.Commands.Requests;
using PremierTest.Domain.Commands.Response;
using PremierTest.Domain.Handlers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremierTest.Api.Controllers
{
    [ApiController]
    [Route("v1/login")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public LoginResponse Login(
            [FromServices]ILoginHandler handler,
            [FromBody] LoginRequest command
            )
        {
            return handler.Handle(command);
        }
    }
}
