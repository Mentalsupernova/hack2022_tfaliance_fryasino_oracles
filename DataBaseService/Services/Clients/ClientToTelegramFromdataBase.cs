using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBaseService.Services.Clients
{
    public class ClientToTelegramFromDataBase
    {
        //TODO: Change this client to TGBot
        public ClientToTelegramFromDataBase()
        {

        }
        public void SendMessage(string inputMessage)
        {

            // создаем канал для обмена сообщениями с сервером
            // параметр - адрес сервера gRPC
            using var channel = GrpcChannel.ForAddress("http://localhost:4996");
            // создаем клиента
            var client = new TelegramBotService.Telegrams.TelegramsClient(channel);

            //Console.Write("Введите имя: ");
            //string name = Console.ReadLine();
            // обмениваемся сообщениями с сервером

            string message = "Base;" + inputMessage;
            var ryply = client.SayHello(new TelegramBotService.HelloRequest { Name = message });
            //Console.WriteLine(ryply);
            //var reply = await client.SayHelloAsync(new HelloRequest { Name = name });
        }
    }
}
