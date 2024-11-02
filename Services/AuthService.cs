using SherlockAPI.Interfaces;
using SherlockAPI.Models;

namespace SherlockAPI.Services;

public class AuthService : IAuthService
{
    public Boolean AuthorizeWebChat(string webId, string token)
    {
        if (token == "WEB1")
        {
            return true;
        }
        return false;
    }
}