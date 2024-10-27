using SherlockAPI.Interfaces;
using SherlockAPI.Models;

namespace SherlockAPI.Services;

public class ChatService : IChatService
{
    private static readonly string[] Summaries = ["Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"];

    public IEnumerable<Chat> Get()
    {
        // return Enumerable.Range(1, 5).Select(index => new Chat
        // {
        //     Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        //     TemperatureC = Random.Shared.Next(-20, 55),
        //     Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        // })
        // .ToArray();
        return [];
    }

    public Chat Create(Chat chat)
    {
        return chat;
    }
}