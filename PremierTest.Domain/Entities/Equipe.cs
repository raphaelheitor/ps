using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Domain.Entities
{
    public class Equipe
    {
        public int Id { get; protected set; }
        public string Nome { get; protected set; }
        public virtual IList<FuncionarioEquipe> FuncionarioEquipe { get; protected set; }

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        protected Equipe() { }
        public Equipe (string nome)
        {
            Nome = nome;
        }
    }
}
