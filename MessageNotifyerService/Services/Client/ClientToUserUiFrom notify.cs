using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageNotifyerService.Services.Client
{
    public class ClientToUserUiFrom_notify
    {
        //TODO: Write Client to UI
        public ClientToUserUiFrom_notify()
        {

        }
        public void SendMessage(string name)
        {

            // создаем канал для обмена сообщениями с сервером
            // параметр - адрес сервера gRPC

            /*            using var channel = GrpcChannel.ForAddress("http://localhost:4999");
                        // создаем клиента
                        var client = new TelegramBotService.Telegrams.TelegramsClient(channel)

                        //Console.Write("Введите имя: ");
                        //string name = Console.ReadLine();
                        // обмениваемся сообщениями с сервером
                        var ryply = client.SayHello(new TelegramBotService.HelloRequest { Name = name });
                        //Console.WriteLine(ryply);
                        //var reply = await client.SayHelloAsync(new HelloRequest { Name = name });*/
        }
    }
}
