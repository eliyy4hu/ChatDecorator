namespace ChatDecorator
{
    public class ChatClientDecoratorBase : IChatClient
    {
        private IChatClient chatClient;

        public ChatClientDecoratorBase(IChatClient chatClient)
        {
            this.chatClient = chatClient;
        }

        public void SendMessage(Message message)
        {
            message = BeforeSendingMessage(message);
            chatClient.SendMessage(message);
        }

        public void ReceiveMessage(Message message)
        {
            message = BeforeReceivingMessage(message);
            chatClient.ReceiveMessage(message);
        }

        public virtual Message BeforeSendingMessage(Message message)
        {
            return message;
        }

        public virtual Message BeforeReceivingMessage(Message message)
        {
            return message;
        }
    }
}