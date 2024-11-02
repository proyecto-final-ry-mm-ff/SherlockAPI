using SherlockAPI.Dtos;
using SherlockAPI.Models;

namespace SherlockAPI.Interfaces;

public interface IChatService
{
    IEnumerable<ChatDto> Get();
    ChatDto Create();
}