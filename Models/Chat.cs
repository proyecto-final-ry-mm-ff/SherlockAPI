using System.ComponentModel.DataAnnotations;

namespace SherlockAPI.Models
{
    public class Chat
    {
        // public DateOnly Date { get; set; }

        // public int TemperatureC { get; set; }

        // public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        // public string? Summary { get; set; }

        public string Id { get; private set; }

        public string? Name { get; set; }

        public static int GlobalChatId = 0;

        public Chat()
        {
            this.Id =  $"_CHAT_{++GlobalChatId}";
        }
    }
}
