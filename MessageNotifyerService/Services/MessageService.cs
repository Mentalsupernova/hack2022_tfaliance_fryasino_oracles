using Grpc.Core;
using MessageNotifyerService.Services.Client;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageNotifyerService
{
    public class MessageService : MessageNotifyer.MessageNotifyerBase
    {
        private readonly ILogger<MessageService> _logger;
        private ClientToDataBaseService ClientToDataBase;
        private ClientToUserUiFrom_notify ClientToUserUI;




        public MessageService(ILogger<MessageService> logger)
        {
            _logger = logger;
            
            Console.WriteLine(_logger);

            //ClientToDataBase = new ClientToDataBaseService();
            //ClientToDataBase.SendMessage("ext");

        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {

            Console.WriteLine("Sting INput: " +
                 request.Name);
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }
    }
}
