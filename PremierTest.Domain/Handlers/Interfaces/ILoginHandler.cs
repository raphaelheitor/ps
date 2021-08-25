using PremierTest.Domain.Commands.Requests;
using PremierTest.Domain.Commands.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Domain.Handlers.Interfaces
{
    public interface ILoginHandler
    {
        LoginResponse Handle(LoginRequest request);
    }
}
