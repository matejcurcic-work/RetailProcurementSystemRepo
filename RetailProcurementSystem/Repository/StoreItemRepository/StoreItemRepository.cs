using Database.Context;
using Database.Models;

namespace RetailProcurementSystem.Repository.StoreItemRepository
{
    public class StoreItemRepository : GenericRepository<StoreItem>, IStoreItemRepository
    {
        public StoreItemRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
