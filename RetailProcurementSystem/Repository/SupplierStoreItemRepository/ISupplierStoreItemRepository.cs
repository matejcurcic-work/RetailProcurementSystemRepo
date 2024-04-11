using Database.Models;

namespace RetailProcurementSystem.Repository.SupplierStoreItemRepository
{
    public interface ISupplierStoreItemRepository : IGenericRepository<SupplierStoreItem>
    {
        Task<bool> SupplierStoreItemExistsAsync(int itemId, int storeId);
    }
}
