using AutoMapper;
using Database.Models;
using RetailProcurementSystem.DTOs;
using RetailProcurementSystem.Repository.StoreItemRepository;

namespace RetailProcurementSystem.Services.StoreItemService
{
    public class StoreItemService : IStoreItemService
    {
        private readonly IStoreItemRepository _storeItemRepository;
        private readonly IMapper _mapper;
        public StoreItemService(IStoreItemRepository storeItemRepository, IMapper mapper)
        {
            _storeItemRepository = storeItemRepository;
            _mapper = mapper;
        }


        public async Task<List<StoreItemDTO>> GetAllStoreItems()
        {

            var storeItems = await _storeItemRepository.GetAllAsync();
            var dtos = storeItems
                .Select(item => new StoreItemDTO
                {
                    Id = item.Id,
                    Name = item.Name,
                    Price = item.Price,
                    Quantity = item.Quantity,
                })
                .ToList();

            return dtos;
        }

        public async Task<StoreItem> GetStoreItem(int id)
        {
            var storeItem = await _storeItemRepository.GetByIdAsync(id);

            return storeItem;
        }

        public async Task InsertNewStoreItem(StoreItem item)
        {
            await _storeItemRepository.AddAsync(item);
        }

        public async Task UpdateStoreItem(StoreItem item)
        {
            await _storeItemRepository.UpdateAsync(item);
        }

        public async Task DeleteStoreItem(int id)
        {
            await _storeItemRepository.DeleteAsync(id);
        }
    }
}
