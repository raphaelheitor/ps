using PremierTest.Application.Commands.Requests;
using PremierTest.Application.Commands.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTest.Application.Handlers.Interfaces
{
    public interface IInformarHoraHandler
    {
        InformarHoraResponse Handle(InformarHoraRequest request);
    }
}
