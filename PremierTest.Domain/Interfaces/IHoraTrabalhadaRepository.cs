using PremierTest.Domain.Entities;
using System.Collections.Generic;

namespace PremierTest.Domain.Interfaces
{
    public interface IHoraTrabalhadaRepository
    {
        /// <summary>
        /// Commands
        /// </summary>
        /// <returns></returns>
        HoraTrabalhada InformarHora(HoraTrabalhada horaTrabalhada);
    }
}
