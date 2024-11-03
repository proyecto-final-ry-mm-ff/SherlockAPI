//using SherlockAPI.Models;

using SherlockDomain.Entities;

namespace SherlockAPI.Dtos
{
    public class MessageDto
    {

        public int Id { get; set; }
        public int ChatId { get; set; }
        public string? Content { get; set; }
        public DateTime TimeStamp { get; private set; }
      //  public string? OperatorId { get; set; }

        public static MessageDto FromEntity(Message msg)
        {
            return new MessageDto()
            {
                Id = msg.Id,
                ChatId = msg.ChatId,
                Content = msg.Content,
                TimeStamp = msg.TimeStamp
            };
        }

    }
}
