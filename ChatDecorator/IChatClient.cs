namespace ChatDecorator
{
    public interface IChatClient
    {
        void SendMessage(Message message);
        void ReceiveMessage(Message message);
    }
}