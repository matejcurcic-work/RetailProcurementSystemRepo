using Database.Context;
using Microsoft.EntityFrameworkCore;
using RetailProcurementSystem.DTOs;

namespace RetailProcurementSystem.Services.Statistics
{
    public class StatisticsService : IStatisticsService
    {
        private readonly ApplicationDbContext _context;

        public StatisticsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<SalesStatisticsDTO>> GetItemsSoldBySupplierAsync(int supplierId)
        {
            var salesStatistics = await _context.SalesRecords
            .Where(s => s.SupplierId == supplierId)
            .GroupBy(s => new { s.StoreItemId })
            .Select(group => new SalesStatisticsDTO
            {
                StoreItemName = group.Select(s => s.StoreItem.Name).FirstOrDefault() ?? "",
                StoreItemId = group.Key.StoreItemId,
                QuantitySold = group.Sum(s => s.QuantitySold),
                TotalAmount = group.Sum(s => s.TotalAmount)
            })
            .ToListAsync();

            return salesStatistics;
        }

        public async Task<StoreItemOfferDTO> GetBestOfferByDiscount(int productId)
        {
            var bestOffer = await _context.SalesRecords
                .Where(record => record.StoreItem.Id == productId && record.StoreItem.Discount.HasValue && record.StoreItem.Discount.Value > 0)
                .OrderByDescending(record => record.StoreItem.Discount)
                .Select(record => new StoreItemOfferDTO
                {
                    StoreItemId = record.StoreItemId,
                    StoreItemName = record.StoreItem.Name,
                    Discount = record.StoreItem.Discount.Value
                })
                .FirstOrDefaultAsync();

            return bestOffer;
        }

        public async Task<StoreItemOfferDTO> GetBestOfferBySales(int productId)
        {
            var bestOffer = await _context.SalesRecords
                .Where(record => record.StoreItem.Id == productId)
                .GroupBy(record => record.StoreItemId)
                .Select(group => new
                {
                    StoreItemId = group.Key,
                    StoreItemName = group.First().StoreItem.Name,
                    TotalQuantitySold = group.Sum(record => record.QuantitySold)
                })
                .OrderByDescending(group => group.TotalQuantitySold)
                .Select(group => new StoreItemOfferDTO
                {
                    StoreItemId = group.StoreItemId,
                    StoreItemName = group.StoreItemName,
                    TotalQuantitySold = group.TotalQuantitySold
                })
                .FirstOrDefaultAsync();

            return bestOffer;
        }
    }
}
