using Database.Models;
using RetailProcurementSystem.DTOs;

namespace RetailProcurementSystem.Services.StoreItemService
{
    public interface IStoreItemService
    {
        Task DeleteStoreItem(int id);
        Task<List<StoreItemDTO>> GetAllStoreItems();
        Task<StoreItem> GetStoreItem(int id);
        Task InsertNewStoreItem(StoreItem item);
        Task UpdateStoreItem(StoreItem item);
    }
}