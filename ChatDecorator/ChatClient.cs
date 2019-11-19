using System;

namespace ChatDecorator
{
    public class ChatClient : IChatClient
    {
        public ChatClient()
        {
        }


        public void SendMessage(Message message)
        {
            Console.WriteLine($"{message.userName} to {message.destinationUserName} : {message.text}");
        }

        public void ReceiveMessage(Message message)
        {
            Console.WriteLine($"{message.userName} to you  : {message.text}");
        }
    }
}