using PremierTest.Application.Queries.Requests;
using PremierTest.Application.Queries.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Application.Handlers.Interfaces
{
    public interface ILoginHandler
    {
        LoginResponse Handle(LoginRequest request);
    }
}
