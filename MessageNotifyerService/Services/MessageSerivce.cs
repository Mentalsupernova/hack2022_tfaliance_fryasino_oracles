using Grpc.Core;
using MessageNotifyerService.Services.Client;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageNotifyerService
{
    public class MessageSerivce : MessageNotifyer.MessageNotifyerBase
    {

        private string MessageToDb;
        private readonly ILogger<MessageSerivce> _logger;
        public MessageSerivce(ILogger<MessageSerivce> logger)
        {
            _logger = logger;
            Console.WriteLine(123);
            ClientToDataBaseService s = new ClientToDataBaseService();
            s.SendMessage(MessageToDb);

        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            this.MessageToDb = request.Name;
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name

            }
            ); 
        }

        private void TestVoid()
        {

            
        }
    }
}
