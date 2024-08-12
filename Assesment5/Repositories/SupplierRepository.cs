using Assesment5.Entity;
using Microsoft.EntityFrameworkCore;

namespace Assesment5.Repositories
{
    public class SupplierRepository:ISupplierRepository
    {
        private readonly Assesment5context _context;

        public SupplierRepository(Assesment5context context)
        {
            _context = context;
        }
        public async Task Add(Supplier supplier)
        {
            await _context.Suppliers.AddAsync(supplier);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Supplier>> GetAllSupplier()
        {
            return await _context.Suppliers.ToListAsync();
        }

        public async Task<Supplier> GetById(int id)
        {
            return await _context.Suppliers.SingleOrDefaultAsync(s => s.SupplierId == id);
        }
        public async Task DeleteById(int id)
        {
            var supplier = await _context.Suppliers.FindAsync(id);
            _context.Suppliers.Remove(supplier);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Supplier supplier)
        {
            _context.Suppliers.Update(supplier);
            await _context.SaveChangesAsync();
        }

    }
}
