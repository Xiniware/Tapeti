﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapeti.Config
{
    public interface ICleanupMiddleware
    {
        Task Handle(IMessageContext context, HandlingResult handlingResult);
    }
}
