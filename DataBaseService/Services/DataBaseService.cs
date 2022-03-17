using DataBaseService.Services;
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
        
        private DataBaseWorker worker;

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
