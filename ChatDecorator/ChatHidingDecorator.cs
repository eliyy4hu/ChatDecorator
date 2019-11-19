using System;
using System.Text;

namespace ChatDecorator
{
    using System.Security.Cryptography;

    public class ChatHidingDecorator : ChatClientDecoratorBase
    {
        public ChatHidingDecorator(IChatClient chatClient) : base(chatClient)
        {
        }

        public override Message BeforeSendingMessage(Message message)
        {
            var userNameBytes =
                new MD5CryptoServiceProvider().ComputeHash(ASCIIEncoding.ASCII.GetBytes(message.userName));
            var destinationUserNameBytes =
                new MD5CryptoServiceProvider().ComputeHash(ASCIIEncoding.ASCII.GetBytes(message.destinationUserName));
            message.userName = BitConverter.ToString(userNameBytes).Replace("-", string.Empty);
            message.destinationUserName = BitConverter.ToString(destinationUserNameBytes).Replace("-", string.Empty);
            return message;
        }
    }
}