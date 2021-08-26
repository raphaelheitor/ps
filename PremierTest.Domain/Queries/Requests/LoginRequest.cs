using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Domain.Queries.Requests
{
    public class LoginRequest
    {
        public string Matricula { get; set; }
        public string Password { get; set; }
    }
}
