using SherlockAPI.Models;

namespace SherlockAPI.Dtos
{
    public class ChatDto
    {
        public required string Id { get; set; }

        public string? Name { get; set; }

        public List<MessageDto> Messages { get; set; } = [];


        public static ChatDto FromEntity(Chat chat)
        {
            return new ChatDto()
            {
                Id = chat.Id,
                Name = chat.Name,
                Messages = chat.Messages.Select(MessageDto.FromEntity).ToList()
            };
        }

    }
}
