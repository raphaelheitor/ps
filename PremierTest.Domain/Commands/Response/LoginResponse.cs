using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Domain.Commands.Response
{
    public class LoginResponse
    {
        public string Status { get; set; }
        public string BearerToken { get; set; }
    }
}
