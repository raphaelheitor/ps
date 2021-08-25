using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Application.Queries.Responses
{
    public class LoginResponse
    {
        public string Nome { get; set; }
        public string Status { get; set; }
        public string BearerToken { get; set; }
    }
}
