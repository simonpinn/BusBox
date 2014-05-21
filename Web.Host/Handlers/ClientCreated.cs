using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Client.Domain.Messages.Events;
using NServiceBus;

namespace Web.Host.Handlers
{
    public class ClientCreated:IHandleMessages<IClientCreated>
    {
        public void Handle(IClientCreated message)
        {
            Console.WriteLine(message);
        }
    }
}