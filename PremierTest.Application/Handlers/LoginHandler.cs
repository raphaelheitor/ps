using PremierTest.Application.Queries.Requests;
using PremierTest.Application.Queries.Responses;
using PremierTest.Application.Handlers.Interfaces;
using PremierTest.Domain.Interfaces;
using PremierTest.Application.Services;
using PremierTest.Application.Services.Interfaces;

namespace PremierTest.Application.Handlers
{
    public class LoginHandler : ILoginHandler
    {
        IFuncionarioRepository _funcionarioRepository;
        ITokenService _tokenService;


        public LoginHandler(IFuncionarioRepository funcionarioRepository, ITokenService tokenService)
        {
            _funcionarioRepository = funcionarioRepository;
            _tokenService = tokenService;
        }
        public LoginResponse Handle(LoginRequest request)
        {
            var pwHash = CriptoService.GenerateHash(request.Password);
            var func = _funcionarioRepository.Login(request.Matricula, pwHash);
            if (func != null)
            {
                var token = _tokenService.GenerateToken(func);
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
