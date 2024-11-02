using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SherlockAPI.Dtos;
using SherlockAPI.Interfaces;
using SherlockAPI.Models;


namespace SherlockAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly ILogger<ChatController> _logger;
        private readonly IChatService _chatService;

        public ChatController(ILogger<ChatController> logger, IChatService chatService)
        {
            _logger = logger;
            _chatService = chatService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var chats = _chatService.Get();
            return Ok(chats);
        }

        [HttpGet]
        [Route("new-instance")]
        public IActionResult getNewInstance()
        {
            ChatDto chatDto = _chatService.Create();
            return Ok(chatDto);
        }

        [HttpGet]
        [Route("identity-questions")]
        public IActionResult getIdentityQuestions()
        {
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
