using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelegramBotService
{
    public class TelegramService : Telegrams.TelegramsBase 
    {
        private readonly ILogger<TelegramService> _logger;
        private ClientToNotify toNotify;
        private ClientToDataBaseService toDataBaseService;

        public TelegramService(ILogger<TelegramService> logger)
        {
            _logger = logger;
            toNotify = new ClientToNotify();
            toDataBaseService = new ClientToDataBaseService();
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
