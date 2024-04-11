using AutoMapper;
using Database.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using RetailProcurementSystem.Controllers;
using RetailProcurementSystem.DTOs;
using RetailProcurementSystem.Services.StoreItemService;

namespace RetailProcurementSystemTests.StoreItem_Tests
{
    public class StoreItemControllerTests
    {
        [Fact]
        public async Task GetAllStoreItems_ReturnsOkResult_WithListOfStoreItems()
        {
            // Arrange
            var storeItems = new List<StoreItemDTO>();
            Mock<IStoreItemService> mockService = GetStoreItemMockRepositoryObject1(storeItems);

            var controller = new StoreItemController(
                mockService.Object,
                Mock.Of<ILogger<StoreItemController>>(),
                Mock.Of<IMapper>());

            // Act
            var result = await controller.GetAllStoreItems();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var model = Assert.IsAssignableFrom<List<StoreItemDTO>>(okResult.Value);
            Assert.Equal(storeItems.Count, model.Count);
        }

        private static Mock<IStoreItemService> GetStoreItemMockRepositoryObject1(List<StoreItemDTO> storeItems)
        {
            var mockService = new Mock<IStoreItemService>();

            mockService.Setup(service => service.GetAllStoreItems())
                .ReturnsAsync(storeItems);

            mockService.Setup(service => service.GetStoreItem(It.IsAny<int>()))
                .ReturnsAsync((StoreItem)null);
            
            return mockService;
        }

        [Fact]
        public async Task GetStoreItemById_ReturnsNotFound_WhenStoreItemDoesNotExist()
        {
            // Arrange
            var storeItems = new List<StoreItemDTO>();
            Mock<IStoreItemService> mockService = GetStoreItemMockRepositoryObject1(storeItems);


            var controller = new StoreItemController(
                mockService.Object,
                Mock.Of<ILogger<StoreItemController>>(),
                Mock.Of<IMapper>());

            // Act
            var result = await controller.GetStoreItemById(1);

            // Assert
            var notFoundResult = Assert.IsType<NotFoundObjectResult>(result.Result);
            Assert.Equal("Store item not found", notFoundResult.Value);
        }

        [Fact]
        public async Task GetStoreItemById_ReturnsOkResult_WithStoreItemDTO_WhenStoreItemExists()
        {
            // Arrange
            var storeItem = new StoreItem { Id = 1, Name = "Item 1" };
            var storeItemDTO = new StoreItemDTO { Id = 1, Name = "Item 1" };
            var mockService = new Mock<IStoreItemService>();
            mockService.Setup(service => service.GetStoreItem(1))
                .ReturnsAsync(storeItem);

            var mockMapper = new Mock<IMapper>();
            mockMapper.Setup(mapper => mapper.Map<StoreItemDTO>(storeItem))
                .Returns(storeItemDTO);

            var controller = new StoreItemController(
                mockService.Object,
                Mock.Of<ILogger<StoreItemController>>(),
                mockMapper.Object);

            // Act
            var result = await controller.GetStoreItemById(1);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var model = Assert.IsAssignableFrom<StoreItemDTO>(okResult.Value);
            Assert.Equal(storeItemDTO, model);
        }
    }
}
