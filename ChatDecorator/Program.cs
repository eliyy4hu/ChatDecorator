namespace ChatDecorator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var chatClient = new ChatClient();
            var encryptingChatClient = new ChatEncryptingDecorator(chatClient);
            encryptingChatClient.SendMessage(new Message(){text = "привет", userName = "v4s1l1y", destinationUserName = "nagibatorXXX"});
            encryptingChatClient.ReceiveMessage(new Message(){text = "Здравствуйте", userName = "nagibatorXXX", destinationUserName = "v4s1l1y"});
            encryptingChatClient.ReceiveMessage(new Message(){text = "<encrypted>Работает шифрование?</encrypted>", userName = "nagibatorXXX", destinationUserName = "v4s1l1y"});
            
            var hidingChatClient = new ChatHidingDecorator(chatClient);
            hidingChatClient.SendMessage(new Message(){text = "*@!!*#!", userName = "v4s1l1y", destinationUserName = "nagibatorXXX"});
            encryptingChatClient.ReceiveMessage(new Message(){text = "лол", userName = "nagibatorXXX", destinationUserName = "v4s1l1y"});
        }
    }
}