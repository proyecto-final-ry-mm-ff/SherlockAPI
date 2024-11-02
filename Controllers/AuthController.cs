using Microsoft.AspNetCore.Mvc;
using SherlockAPI.Interfaces;
using SherlockAPI.Models;


namespace SherlockAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;
        private readonly IAuthService _authService;

        public AuthController(ILogger<AuthController> logger, IAuthService authService)
        {
            _logger = logger;
            _authService = authService;
        }

        [HttpPost]
        [Route("auth-web")]
        public IActionResult AuthorizeWebChat([FromBody] Auth au)
        {
            bool authorized = _authService.AuthorizeWebChat(au.WebId, au.Token);
            return Ok($"{authorized} - Autorizado");
        }
    }
}
