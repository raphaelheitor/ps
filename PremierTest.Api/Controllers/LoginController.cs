using Microsoft.AspNetCore.Mvc;
using PremierTest.Domain.Queries.Requests;
using PremierTest.Domain.Queries.Responses;
using PremierTest.Domain.Handlers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

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
