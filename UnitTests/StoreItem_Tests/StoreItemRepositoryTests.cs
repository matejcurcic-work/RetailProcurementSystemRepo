using AutoMapper;
using Database.Context;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Moq;
using RetailProcurementSystem.Repository.StoreItemRepository;
using RetailProcurementSystem.Services.StoreItemService;
using System.Collections.Generic;

namespace RetailProcurementSystemTests.StoreItem_Tests
{
    public class StoreItemRepositoryTests : StoreItemTestBase, IDisposable
    {
        private readonly ApplicationDbContext dbContext;

        public StoreItemRepositoryTests()
        {
            var options = GetInMemoryDatabase();

            dbContext = new ApplicationDbContext(options);
        }


        [Fact]
        public async Task GetByIdAsync_ReturnsStoreItem()
        {
            // Arrange
            GetMockServiceObjects(out List<StoreItem> storeItems, out StoreItemService storeItemService);

            // Act
            var result = await storeItemService.GetStoreItem(1);


            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.Id);
            Assert.Equal("Item 1", result.Name);
            Assert.Equal(10.0m, result.Price);
            Assert.Equal(5, result.Quantity);
        }


        [Fact]
        public async Task GetAllStoreItems_ReturnsAllStoreItems()
        {
            // Arrange
            GetMockServiceObjects(out List<StoreItem> storeItems, out StoreItemService storeItemService);

            // Act
            var result = await storeItemService.GetAllStoreItems();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(storeItems.Count, result.Count);
            Assert.Equal(storeItems[0].Name, result[0].Name);
            Assert.Equal(storeItems[0].Price, result[0].Price);
            Assert.Equal(storeItems[0].Quantity, result[0].Quantity);
            Assert.Equal(storeItems[1].Name, result[1].Name);
            Assert.Equal(storeItems[1].Price, result[1].Price);
            Assert.Equal(storeItems[1].Quantity, result[1].Quantity);
        }


        [Fact]
        public async Task AddNewStoreItems_ReturnsAllSavedStoreItems()
        {
            // Arrange
            var options = GetInMemoryDatabase();

            using var dbContext = new ApplicationDbContext(options);
            var storeItemRepository = new StoreItemRepository(dbContext);
            var mockMapper = new Mock<IMapper>();
            var storeItemService = new StoreItemService(storeItemRepository, mockMapper.Object);


            // Act
            for (int i = 1; i <= 10; i++)
            {
                var addNewStoreItem = new StoreItem()
                {
                    Id = i,
                    Name = "New Store Item",
                    Price = 10.0m * i,
                    Quantity = 10 + i
                };

                await storeItemService.InsertNewStoreItem(addNewStoreItem);
            }

            var result = await storeItemService.GetAllStoreItems();

            // Assert
            Assert.Equal(10, result.Count);
        }


        [Fact]
        public async Task UpdateStoreItem_CallsUpdateAsyncWithCorrectItem()
        {
            // Arrange
            var options = GetInMemoryDatabase();

            using var dbContext = new ApplicationDbContext(options);
            var storeItemRepository = new StoreItemRepository(dbContext);
            var mockMapper = new Mock<IMapper>();
            var storeItemService = new StoreItemService(storeItemRepository, mockMapper.Object);


            var newItem = new StoreItem
            {
                Id = 20,
                Name = "Original Item",
                Price = 15.0m,
                Quantity = 5
            };
            await storeItemService.InsertNewStoreItem(newItem);
            dbContext.Entry(newItem).State = EntityState.Detached;



            var updatedItem = new StoreItem()
            {
                Id = 20,
                Name = "Updated Item",
                Price = 20.0m,
                Quantity = 15
            };

            // Act
            await storeItemService.UpdateStoreItem(updatedItem);

            // Assert
            var updatedItemFromDatabase = await dbContext.StoreItems.FindAsync(updatedItem.Id);

            Assert.NotNull(updatedItemFromDatabase);
            Assert.Equal(updatedItem.Name, updatedItemFromDatabase.Name);
            Assert.Equal(updatedItem.Price, updatedItemFromDatabase.Price);
        }


        public void Dispose()
        {
            dbContext.Database.EnsureDeleted();
            dbContext.Dispose();
        }
    }
}