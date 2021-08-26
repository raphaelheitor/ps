﻿using PremierTest.Application.Commands.Requests;
using PremierTest.Application.Commands.Responses;

namespace PremierTest.Application.Handlers.Interfaces
{
    public interface IInformarHoraHandler
    {
        InformarHoraResponse Handle(InformarHoraRequest request);
    }
}
