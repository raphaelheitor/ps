﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Application.Commands.Requests
{
    public class InformarHoraRequest
    {
        public int FuncionarioId { get; set; }
        public int ProjetoId { get; set; }
        public decimal HorasTrabalhadas { get; set; }
    }
}