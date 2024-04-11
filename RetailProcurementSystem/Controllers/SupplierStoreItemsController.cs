using Database.Models;
using Microsoft.AspNetCore.Mvc;
using RetailProcurementSystem.DTOs;
using RetailProcurementSystem.Services.SupplierStoreItemService;

namespace RetailProcurementSystem.Controllers
{
    [ApiController]
    [Route("/api/supplier-store-items")]
    public class SupplierStoreItemsController : ControllerBase
    {
        private readonly ISupplierStoreItemService _supplierStoreItemService;
        private readonly ILogger<SupplierStoreItemsController> _logger;


        public SupplierStoreItemsController(ISupplierStoreItemService supplierStoreItemService, ILogger<SupplierStoreItemsController> logger)
        {
            _supplierStoreItemService = supplierStoreItemService;
            _logger = logger;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(List<SupplierStoreItemDTO>))]
        public async Task<ActionResult<List<SupplierStoreItemDTO>>> GetAllStoreItems()
        {
            var supplierStoreItems = await _supplierStoreItemService.GetAllSupplierStoreItems();

            return Ok(supplierStoreItems);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> InsertNewSupplierStoreItem(int supplierId, int storeId)
        {
            try
            {
                var inserted = await _supplierStoreItemService.InsertNewStoreItem(supplierId, storeId);

                return Ok();

            }
            catch (Exception ex)
            {
                _logger.LogError($"Error at {nameof(InsertNewSupplierStoreItem)}:\n {ex.Message} \n InnerMessageError: {ex.InnerException} ");
                return BadRequest($"Error on POST\n{ex.Message}\n InnerMessageError:\n{ex.InnerException} ");
            }
           
        }

        [HttpDelete("{supplierId:int}/{storeId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteSupplierStoreItem(int supplierId, int storeId)
        {
            try
            {
                var deleted = await _supplierStoreItemService.DeleteStoreItem(supplierId, storeId);
                
                return Ok();

            }
            catch (Exception ex)
            {
                _logger.LogError($"Error at {nameof(DeleteSupplierStoreItem)}:\n {ex.Message} \n InnerMessageError: {ex.InnerException} ");
                return BadRequest($"Error on DELETE\n{ex.Message}\n InnerMessageError:\n{ex.InnerException} ");
            }
        }
    }
}
