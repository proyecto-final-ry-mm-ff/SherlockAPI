using SherlockAPI.Interfaces;

namespace SherlockAPI.Services;

public class AuthService : IAuthService
{
    public bool AuthorizeWebChat(string webId, string token)
    {
        if (token == "WEB1")
        {
            return true;
        }
        return false;
    }
}