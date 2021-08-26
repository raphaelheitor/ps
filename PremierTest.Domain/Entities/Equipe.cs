using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Domain.Entities
{
    public class Equipe
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual IList<FuncionarioEquipe> FuncionarioEquipe { get; set; }
        public virtual IList<Projeto> Projetos { get; set; }
        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        public Equipe() { }
        public Equipe (string nome)
        {
            Nome = nome;
        }
    }
}
