﻿using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageNotifyerService.Services.Client
{
    public class ClientToDataBaseService
    {
        public async void SendMessage()
        {
            // создаем канал для обмена сообщениями с сервером
            // параметр - адрес сервера gRPC
            using var channel = GrpcChannel.ForAddress("https://localhost:4999");
            // создаем клиента
            var client = new Greeter.GreeterClient(channel);
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            // обмениваемся сообщениями с сервером
            var reply = await client.SayHelloAsync(new HelloRequest { Name = name });
            Console.WriteLine("Ответ сервера: " + reply.Message);
            Console.ReadKey();
        }
    }

    
}
