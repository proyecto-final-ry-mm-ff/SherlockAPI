using SherlockAPI.Dtos;
using SherlockAPI.Interfaces;
//using SherlockAPI.Models;
using SherlockDomain.Entities;
using SherlockDomain.Repositories;

namespace SherlockAPI.Services;

public class ChatService(IChatRepository chatRepository) : IChatService
{

    public ChatDto Create()
    {
        Chat myChat = new Chat();
        ChatDto chatDto = ChatDto.FromEntity(myChat);
        return chatDto;
    }

    public async Task<int> CreateNewInstance()
    {
        //TODO esto deberia ser un DTO   
        Chat adHocChat = new Chat();
        int chatId = await chatRepository.CreateNewInstanceAsync(adHocChat);
        return chatId;

    }

    public async Task<Chat?> GetById(int id)
    {
       var chat  = await  chatRepository.GetByIdAsync(id);
        return chat;
    }


}
