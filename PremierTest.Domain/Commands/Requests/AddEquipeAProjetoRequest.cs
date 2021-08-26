using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Domain.Commands.Requests
{
    public class AddEquipeAProjetoRequest
    {
        public int ProjetoId { get; set; }
        public int EquipeId { get; set; }
    }
}
