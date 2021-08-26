using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Domain.Entities
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Password { get; set; }
        public string Perfil { get; set; }
        public virtual IList<HoraTrabalhada> HorasTrabalhadas { get; set; }
        public virtual IList<FuncionarioEquipe> FuncionarioEquipe { get; set; }
    }
}
