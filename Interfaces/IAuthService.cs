using SherlockAPI.Models;

namespace SherlockAPI.Interfaces;

public interface IAuthService
{
    Boolean AuthorizeWebChat(string webId, string token);
}