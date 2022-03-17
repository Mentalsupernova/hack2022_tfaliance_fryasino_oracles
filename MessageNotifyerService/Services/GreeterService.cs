using Grpc.Core;
using MessageNotifyerService.Services.Client;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageNotifyerService
{
    public class GreeterService : MessageNotifyer.MessageNotifyerBase
    {
        private readonly ILogger<GreeterService> _logger;
        ClientToDataBaseService t;

        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
            
            Console.WriteLine(_logger);

            t = new ClientToDataBaseService();
            t.SendMessage("ext");

        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
         

            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }
    }
}
