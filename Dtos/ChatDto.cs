//using SherlockAPI.Models;
using SherlockDomain.Entities;

namespace SherlockAPI.Dtos
{
    public class ChatDto
    {
        public int Id { get; set; }


        public List<MessageDto> Messages { get; set; } = [];


        public static ChatDto FromEntity(Chat chat)
        {
            return new ChatDto()
            {
                Id = chat.Id,
                Messages = chat.Messages.Select(MessageDto.FromEntity).ToList()
            };
        }

    }
}
