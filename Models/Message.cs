using System.ComponentModel.DataAnnotations;

namespace SherlockAPI.Models
{
    public class Message
    {

        public required string Id { get; set; }
        public required string ChatId { get; set; }
        public string? Content { get; set; }
        public DateTime TimeStamp { get; private set; }
        public string? OperatorId { get; set; }

    }
}
