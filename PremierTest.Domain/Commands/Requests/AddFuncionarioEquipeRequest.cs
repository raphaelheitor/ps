using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Domain.Commands.Requests
{
    public class AddFuncionarioEquipeRequest
    {
        public int FuncionarioId { get; set; }
        public int EquipeId { get; set; }
    }
}
