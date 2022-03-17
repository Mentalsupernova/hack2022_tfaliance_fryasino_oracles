using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UiClient.ClientsToServices
{
    public class ClientToDataBaseService
    {
        //TODO: Change this client to TGBot
        public ClientToDataBaseService()
        {

        }
        public void SendMessage(string name)
        {

            // создаем канал для обмена сообщениями с сервером
            // параметр - адрес сервера gRPC
            using var channel = GrpcChannel.ForAddress("http://localhost:4999");
            // создаем клиента
            var client = new DataBaseService.DataBase.DataBaseClient(channel);

            //Console.Write("Введите имя: ");
            //string name = Console.ReadLine();
            // обмениваемся сообщениями с сервером
            var ryply = client.SayHello(new DataBaseService.HelloRequest { Name = name });
            //Console.WriteLine(ryply);
            //var reply = await client.SayHelloAsync(new HelloRequest { Name = name });
        }
    }
}
