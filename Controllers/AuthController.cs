using Microsoft.AspNetCore.Http.HttpResults;
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
            if (!authorized)
            {
                return Unauthorized("NO AUTH");
            }

            ClientIdentificationParameters cip = new ClientIdentificationParameters();
            cip.isRequired = true;
            cip.DisplayOrder = 1;
            cip.Name = "Nombre";
            cip.Id = "1";

            ClientIdentificationParameters cip2 = new ClientIdentificationParameters();
            cip2.isRequired = true;
            cip2.DisplayOrder = 2;
            cip2.Name = "Celular";
            cip2.Id = "2";

            var response = new { cip, cip2 };

            return Ok(response);
        }
    }
}
