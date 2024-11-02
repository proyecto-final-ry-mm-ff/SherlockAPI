using System.ComponentModel.DataAnnotations;

namespace SherlockAPI.Models
{
    public class Chat
    {
        // public DateOnly Date { get; set; }

        // public int TemperatureC { get; set; }

        // public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        // public string? Summary { get; set; }

        public int Id { get; set; } = 0;

        public string? Name { get; set; }

        public Chat()
        {
            this.Id = Id++;
        }
    }
}
