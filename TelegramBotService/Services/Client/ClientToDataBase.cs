using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelegramBotService
{
    public class ClientToDataBaseService
    {
        private GrpcChannel channel;
        private DataBaseService.DataBase.DataBaseClient Client;
        //TODO: Change this client to TGBot
        public ClientToDataBaseService()
        {
            channel = GrpcChannel.ForAddress("http://localhost:4999");
            Client = new DataBaseService.DataBase.DataBaseClient(channel);
        }
        public void SendMessage(string name)
        {

            // создаем канал для обмена сообщениями с сервером
            // параметр - адрес сервера gRPC
            
            // создаем клиента

            //Console.Write("Введите имя: ");
            //string name = Console.ReadLine();
            // обмениваемся сообщениями с сервером
            var ryply = Client.SayHello(new DataBaseService.HelloRequest { Name = name });
            //Console.WriteLine(ryply);
            //var reply = await client.SayHelloAsync(new HelloRequest { Name = name });
        }
    }
}
