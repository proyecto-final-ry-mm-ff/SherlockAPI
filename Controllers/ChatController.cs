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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var chat = await _chatService.GetById(id);

            if (chat is null)
            {
                return NotFound();
            }
            return Ok(chat);
        }

        [HttpGet]
        [Route("new-instance")]
        public  async Task<IActionResult> getNewInstance()
        {
            int chatId = await _chatService.CreateNewInstance();
            Response.Headers.AccessControlExposeHeaders = "Location";
            return CreatedAtAction(nameof(GetById), new { id=  chatId }, null);
        }

        [HttpGet]
        [Route("identity-questions")]
        public IActionResult getIdentityQuestions()
        {
            ClientIdentificationParameter cip = new ClientIdentificationParameter();
            cip.IsRequired = true;
            cip.DisplayOrder = 1;
            cip.Name = "Nombre";
            cip.Id = "1";

            ClientIdentificationParameter cip2 = new ClientIdentificationParameter();
            cip2.IsRequired = true;
            cip2.DisplayOrder = 2;
            cip2.Name = "Celular";
            cip2.Id = "2";

            ClientIdentificationParameterDto cipDto1 = ClientIdentificationParameterDto.FromEntity(cip);
            ClientIdentificationParameterDto cipDto2 = ClientIdentificationParameterDto.FromEntity(cip2);


            var response = new { cipDto1, cipDto2 };
            return Ok(response);
        }

    }
}
