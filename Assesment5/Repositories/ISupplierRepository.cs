using Assesment5.Entity;

namespace Assesment5.Repositories
{
    public interface ISupplierRepository
    {
        Task<List<Supplier>> GetAllSupplier();
        Task<Supplier> GetById(int id);
        Task Update(Supplier supplier);
        Task DeleteById(int id);
        Task Add(Supplier supplier);

    }
}
