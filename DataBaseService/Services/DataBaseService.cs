using DataBaseService.Services;
using DataBaseService.Services.Clients;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBaseService
{
    public class DataBaseService : DataBase.DataBaseBase
    {
        
        private DataBaseWorker worker; // Класс для работы с БД
        private ClientToTelegramFromDataBase clienToTelegram; // Клиент к TG
        private ClientToUiFromDataBase ClientToUi;   //Клиент к UI

        private readonly ILogger<DataBaseService> _logger;
        public DataBaseService(ILogger<DataBaseService> logger)
        {

            worker = new DataBaseWorker();
            _logger = logger;
            Console.WriteLine(_logger);

            
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            //TODO: Deseriliaze string and do somethings
            //worker.

            return Task.FromResult(new HelloReply
            {
                

                Message = "Hello " + request.Name
            });
        }
    }
}
