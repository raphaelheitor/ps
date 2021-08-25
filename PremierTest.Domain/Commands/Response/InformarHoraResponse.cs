using PremierTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Domain.Commands.Response
{
    public class InformarHoraResponse
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public HoraTrabalhada HoraTrabalhada { get; set; }
    }
}
