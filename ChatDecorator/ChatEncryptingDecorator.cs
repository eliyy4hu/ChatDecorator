using System.Text.RegularExpressions;

namespace ChatDecorator
{
    public class ChatEncryptingDecorator : ChatClientDecoratorBase
    {
        private Regex regex = new Regex("(<encrypted>)(.*)(</encrypted>)");

        public ChatEncryptingDecorator(IChatClient chatClient) : base(chatClient)
        {
        }

        public override Message BeforeSendingMessage(Message message)
        {
            message.text = $"<encrypted>{message.text}</encrypted>";
            return message;
        }

        public override Message BeforeReceivingMessage(Message message)
        {
            var match = regex.Match(message.text);
            if (!match.Success)
                return message;
            message.text = match.Groups[2].Value;
            return message;
        }
    }
}