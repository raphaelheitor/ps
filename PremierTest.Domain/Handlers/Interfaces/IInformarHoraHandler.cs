using PremierTest.Domain.Commands.Requests;
using PremierTest.Domain.Commands.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Domain.Handlers.Interfaces
{
    public interface IInformarHoraHandler
    {
        InformarHoraResponse Handle(InformarHoraRequest request);
    }
}
