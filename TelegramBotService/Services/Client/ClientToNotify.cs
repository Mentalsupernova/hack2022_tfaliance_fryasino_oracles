using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelegramBotService
{
    public class ClientToNotify
    {
        private GrpcChannel channel;
        private MessageNotifyerService.MessageNotifyer.MessageNotifyerClient Client;
        public ClientToNotify()
        {
            channel = GrpcChannel.ForAddress("http://localhost:5000");
            Client = new MessageNotifyerService.MessageNotifyer.MessageNotifyerClient(channel);
        }
        public void SendMessage(string name)
        {

            // создаем канал для обмена сообщениями с сервером
            // параметр - адрес сервера gRPC

            // создаем клиента
            

            //Console.Write("Введите имя: ");
            //string name = Console.ReadLine();
            // обмениваемся сообщениями с сервером
            var ryply = Client.SayHello(new MessageNotifyerService.HelloRequest { Name = name });
            //Console.WriteLine(ryply);
            //var reply = await client.SayHelloAsync(new HelloRequest { Name = name });
        }
    }
}
