using Assesment5.Entity;
using Microsoft.EntityFrameworkCore;

namespace Assesment5.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly Assesment5context _context;

        public ItemRepository(Assesment5context context)
        {
            _context = context;
        }

        public async Task AddItem(Item item)
        {
            await _context.Items.AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteById(int id)
        {
            var product = await _context.Items.FindAsync(id);
            _context.Items.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Item>> GetAllItem()
        {
            return await _context.Items.ToListAsync();
        }

        public async Task<Item> GetItemByIdAsync(int id)
        {
            return _context.Items.SingleOrDefault(p => p.ItemId == id);
        }

        public async Task<Item> GetItemByNameAsync(string name)
        {
            return _context.Items.FirstOrDefault(p => p.ItemName == name);
        }
    }
}
