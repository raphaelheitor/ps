using PremierTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Application.Commands.Responses
{
    public class InformarHoraResponse
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public HoraTrabalhada HoraTrabalhada { get; set; }
    }
}
