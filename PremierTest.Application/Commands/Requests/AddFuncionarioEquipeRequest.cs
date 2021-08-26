using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Application.Commands.Requests
{
    public class AddFuncionarioEquipeRequest
    {
        public int FuncionarioId { get; set; }
        public int EquipeId { get; set; }
    }
}
