using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Domain.Entities
{
    public class HoraTrabalhada
    {
        public int Id { get; set; }
        public int ProjetoId { get; set; }
        public int FuncionarioId { get; set; }
        public decimal Horas { get; set; }
        public Funcionario Colaborador { get; set; }
        public Projeto Projeto { get; set; }
    }
}
