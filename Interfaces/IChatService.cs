using SherlockAPI.Models;

namespace SherlockAPI.Interfaces;

public interface IChatService
{
    IEnumerable<Chat> Get();
    Chat Create(Chat chat);
}