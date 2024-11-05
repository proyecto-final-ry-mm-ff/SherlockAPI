using SherlockDomain.Entities;

namespace SherlockAPI.Interfaces
{
    public interface IChatService
    {
        Task<Chat?> GetById(int id);

        Task<int> CreateNewInstance();
    }
}