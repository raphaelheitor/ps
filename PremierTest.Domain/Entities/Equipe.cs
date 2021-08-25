using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Domain.Entities
{
    public class Equipe
    {
        public int Id { get; set; }
        public int Nome { get; set; }
        public virtual ICollection<Funcionario> Colaboradores { get; set; }
        public virtual ICollection<Projeto> Projetos { get; set; }
    }
}
