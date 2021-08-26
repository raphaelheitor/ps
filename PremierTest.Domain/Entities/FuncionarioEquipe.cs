using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Domain.Entities
{
    public class FuncionarioEquipe
    {
        public int FuncionarioId { get; protected set; }
        public int EquipeId { get; protected set; }
        public Funcionario Funcionario { get; set; }
        public Equipe Equipe { get; set; }

        protected FuncionarioEquipe() { }

        public FuncionarioEquipe(int funcionarioId, int equipeId)
        {
            FuncionarioId = funcionarioId;
            EquipeId = equipeId;
        }
    }
}
