using RetailProcurementSystem.DTOs;

namespace RetailProcurementSystem.Services.Statistics
{
    public interface IStatisticsService
    {
        Task<StoreItemOfferDTO> GetBestOfferByDiscount(int productId);
        Task<StoreItemOfferDTO> GetBestOfferBySales(int productId);
        Task<List<SalesStatisticsDTO>> GetItemsSoldBySupplierAsync(int supplierId);
    }
}
