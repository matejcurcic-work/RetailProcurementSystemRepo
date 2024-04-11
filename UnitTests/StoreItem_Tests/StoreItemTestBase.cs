using AutoMapper;
using Database.Context;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using RetailProcurementSystem.Repository.StoreItemRepository;
using RetailProcurementSystem.Services.StoreItemService;

namespace RetailProcurementSystemTests.StoreItem_Tests
{
    public class StoreItemTestBase
    {
        protected static void GetStoreItemMockRepositoryObject(Mock<IStoreItemRepository> mockRepository, List<StoreItem> storeItems)
        {
            mockRepository
                .Setup(x => x.GetByIdAsync(It.IsAny<int>()))
                .ReturnsAsync(storeItems.First());

            mockRepository.Setup(x => x.GetAllAsync())
                .ReturnsAsync(storeItems);

            mockRepository.Setup(x => x.AddAsync(It.IsAny<StoreItem>()))
                .Returns(Task.CompletedTask)
                .Callback((StoreItem item) =>
                {
                    storeItems.Add(item);
                });

            mockRepository.Setup(x => x.UpdateAsync(It.IsAny<StoreItem>()))
                .Returns(Task.CompletedTask);
        }


        protected static DbContextOptions<ApplicationDbContext> GetInMemoryDatabase()
        {
            return new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;
        }


        protected static void GetMockServiceObjects(out List<StoreItem> storeItems, out StoreItemService storeItemService)
        {
            var mockRepository = new Mock<IStoreItemRepository>();
            var mockMapper = new Mock<IMapper>();
            storeItems = GetStoreItems();
            GetStoreItemMockRepositoryObject(mockRepository, storeItems);

            storeItemService = new StoreItemService(mockRepository.Object, mockMapper.Object);
        }


        private static List<StoreItem> GetStoreItems()
        {
            return new List<StoreItem>
            {
                new() { Id = 1, Name = "Item 1", Price = 10.0m, Quantity = 5 },
                new() { Id = 2, Name = "Item 2", Price = 15.0m, Quantity = 3 },
                new() { Id = 3, Name = "Item 3", Price = 5.0m, Quantity = 7 }
            };
        }
    }
}
