using System.ComponentModel.DataAnnotations;

namespace SherlockAPI.Models
{
    public class Chat
    {

        public int Id { get; private set; }

        public string? Name { get; set; }

        public List<Message> Messages { get; set; } = [];

        public static int GlobalChatId = 0;

        public Chat()
        {
            this.Id = ++GlobalChatId;
        }
    }
}
