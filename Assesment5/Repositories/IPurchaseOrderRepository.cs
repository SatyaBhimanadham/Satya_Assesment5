using Assesment5.Entity;

namespace Assesment5.Repositories
{
    public interface IPurchaseOrderRepository
    {
        void AddOrder(Item item);
        Item GetOrder(int ItemId);
        List<Item> GetAllOrders();
        void Delete(int ItemId);
    }
}
