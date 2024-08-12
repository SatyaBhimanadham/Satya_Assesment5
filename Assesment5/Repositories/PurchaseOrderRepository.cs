using Assesment5.Entity;

namespace Assesment5.Repositories
{
    public class PurchaseOrderRepository : IPurchaseOrderRepository
    {
        private readonly Assesment5context context;

        public PurchaseOrderRepository(Assesment5context context)
        {
            this.context = context;
        }
        public void AddOrder(Item item)
        {
            context.Items.Add(item);
            context.SaveChanges();
        }
        public void Delete(int ItemId)
        {
            var item = context.Items.Find(ItemId);
            context.Items.Remove(item);
            context.SaveChanges();
        }

        public Item GetOrder(int ItemId)
        {
            var order = context.Items.Find(ItemId);
            return order;
        }
        public List<Item> GetAllOrders()
        {
            return context.Items.ToList();
        }
    }
}
