using Assesment5.Entity;

namespace Assesment5.Repositories
{
    public interface IItemRepository
    {

        Task<List<Item>> GetAllItem();
        Task AddItem(Item item);
        Task<Item> GetItemByIdAsync(int id);
        Task<Item> GetItemByNameAsync(string name);
        Task DeleteById(int id);
    }
}
