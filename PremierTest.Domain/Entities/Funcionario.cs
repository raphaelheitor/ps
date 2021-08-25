using PremierTest.Domain.Entities.Enum;
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
        public Perfil Perfil { get; set; }
        public virtual ICollection<Equipe> Equipes { get; set; }
        public virtual ICollection<HoraTrabalhada> HorasTrabalhadas { get; set; }
    }
}
