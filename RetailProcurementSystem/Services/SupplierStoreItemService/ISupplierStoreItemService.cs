using RetailProcurementSystem.DTOs;

namespace RetailProcurementSystem.Services.SupplierStoreItemService
{
    public interface ISupplierStoreItemService
    {
        Task<List<SupplierStoreItemDTO>> GetAllSupplierStoreItems();
        Task<bool> InsertNewStoreItem(int supplierId, int storeId);
        Task<bool> DeleteStoreItem(int supplierId, int storeId);
    }
}
