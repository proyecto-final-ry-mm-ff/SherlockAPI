using System.ComponentModel.DataAnnotations;

namespace SherlockAPI.Models
{
    public class Chat
    {

        public string Id { get; private set; }

        public string? Name { get; set; }

        public List<Message> Messages { get; set; } = [];

        public static int GlobalChatId = 0;

        public Chat()
        {
            this.Id = $"_CHAT_{++GlobalChatId}";
        }
    }
}
