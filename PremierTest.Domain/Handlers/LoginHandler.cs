using PremierTest.Domain.Commands.Requests;
using PremierTest.Domain.Commands.Response;
using PremierTest.Domain.Handlers.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Domain.Handlers
{
    public class LoginHandler : ILoginHandler
    {
        public LoginResponse Handle(LoginRequest request)
        {
            //login cliente;

            return new LoginResponse
            {
                Status = "Login Realizado",
                BearerToken = "asdfhasduihasdfiufhasda"
            };
        }
    }
}
