using PremierTest.Application.Queries.Requests;
using PremierTest.Application.Queries.Responses;
using PremierTest.Application.Handlers.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using PremierTest.Domain.Interfaces;
using PremierTest.Application.Services;

namespace PremierTest.Application.Handlers
{
    public class LoginHandler : ILoginHandler
    {
        IFuncionarioRepository _funcionarioRepository;

        public LoginHandler(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }
        public LoginResponse Handle(LoginRequest request)
        {
            var pwHash = CriptoService.GenerateHash(request.Password);
            var func = _funcionarioRepository.Login(request.Matricula, pwHash);
            if (func != null)
            {
                var token = TokenService.GenerateToken(func);
                return new LoginResponse
                {
                    Status = "Login Realizado",
                    Nome = func.Nome,
                    BearerToken = token
                };
            }
            else
                return new LoginResponse
                {
                    Status = "Login Falhou",
                    Nome = "",
                    BearerToken = ""
                };

        }
    }
}
