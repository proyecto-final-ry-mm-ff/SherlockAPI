using System.ComponentModel.DataAnnotations;

namespace SherlockAPI.Models
{
    public class Message
    {

        public  int Id { get; set; }
        public  int ChatId { get; set; }
        public string? Content { get; set; }
        public DateTime TimeStamp { get; private set; }
        public string? OperatorId { get; set; }

    }
}
