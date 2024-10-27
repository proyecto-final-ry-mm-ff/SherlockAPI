using Microsoft.AspNetCore.Mvc;
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

        [HttpPost]
        public IActionResult createChat([FromBody] Chat chat)
        {
           // Chat myChat = _chatService.Create(chat); hola
            return Ok(chat.Name);
        }
    }
}
