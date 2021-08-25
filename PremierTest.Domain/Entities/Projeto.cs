﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Domain.Entities
{
    public class Projeto
    {
        public int Id { get; set; }
        public int EquipeId { get; set; }
        public string Nome { get; set; }
        public DateTime Inicio { get; set; }
        public Equipe Equipe { get; set; }
        public virtual ICollection<HoraTrabalhada> HorasTrabalhadas { get; set; }
    }
}
