using AutoMapper;
using Database.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RetailProcurementSystem.DTOs;
using RetailProcurementSystem.Services.StoreItemService;


namespace RetailProcurementSystem.Controllers
{
    [ApiController]
    [Route("api/store-items")]
    public class StoreItemController : ControllerBase
    {
        private readonly IStoreItemService _storeItemService;
        private readonly ILogger<StoreItemController> _logger;
        private readonly IMapper _mapper;

        public StoreItemController(IStoreItemService storeItemService, ILogger<StoreItemController> logger, IMapper mapper)
        {
            _storeItemService = storeItemService;
            _logger = logger;
            _mapper = mapper;
        }

        [Authorize]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<StoreItemDTO>))]
        public async Task<ActionResult<List<StoreItemDTO>>> GetAllStoreItems()
        {
            var storeItem = await _storeItemService.GetAllStoreItems();

            return Ok(storeItem);
        }


        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<StoreItemDTO>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<StoreItemDTO>>> GetStoreItemById(int id)
        {
            var storeItem = await _storeItemService.GetStoreItem(id);

            if (storeItem is null)
            {
                return NotFound("Store item not found");
            }

            var dto = _mapper.Map<StoreItemDTO>(storeItem);

            return Ok(dto);
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(StoreItemDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> InsertNewStoreItem(StoreItem storeItem)
        {
            try
            {
                await _storeItemService.InsertNewStoreItem(storeItem);

                return CreatedAtAction(nameof(GetStoreItemById), new { id = storeItem.Id }, storeItem);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error at {nameof(InsertNewStoreItem)}:\n {ex.Message} \n InnerMessageError: {ex.InnerException} ");
                
                return BadRequest($"Error on POST\n{ex.Message}\n InnerMessageError:\n{ex.InnerException} ");
            }
        }


        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateStoreItem(int id, [FromBody] StoreItem storeItem)
        {
            var existingItem = await _storeItemService.GetStoreItem(id);

            if (existingItem is null || id != storeItem.Id)
            {
                return NotFound("Store item is not found. Check if the item exists.");
            }


            try
            {
                await _storeItemService.UpdateStoreItem(storeItem);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error at {nameof(UpdateStoreItem)}:\n {ex.Message} \n InnerMessageError: {ex.InnerException} ");

                return BadRequest($"Error on PUT\n{ex.Message}\n InnerMessageError:\n{ex.InnerException} ");
            }
        }


        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteStoreItem(int id)
        {
            var storeItem = await _storeItemService.GetStoreItem(id);

            if (storeItem is null)
            {
                return NotFound($"Item with Id: {id} does not exist.");
            }

            try
            {
                await _storeItemService.DeleteStoreItem(id);
            
                return Ok();

            }
            catch (Exception ex)
            {
                _logger.LogError($"Error at {nameof(DeleteStoreItem)}:\n {ex.Message} \n InnerMessageError: {ex.InnerException} ");

                return BadRequest($"Error on DELETE\n{ex.Message}\n InnerMessageError:\n{ex.InnerException} ");
            }
        }
    }
}
