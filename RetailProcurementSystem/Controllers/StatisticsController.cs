using Database.Enums;
using Microsoft.AspNetCore.Mvc;
using RetailProcurementSystem.DTOs;
using RetailProcurementSystem.Services.Statistics;

namespace RetailProcurementSystem.Controllers
{
    [ApiController]
    [Route("api/statistics")]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticsService _statisticsService;

        public StatisticsController(IStatisticsService statisticsService)
        {
            _statisticsService = statisticsService;
        }


        [HttpGet("supplier/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<SalesStatisticsDTO>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAllStoreItems(int id)
        {
            var statistics = await _statisticsService.GetItemsSoldBySupplierAsync(id);

            if (statistics is not null)
            {
               return Ok(statistics);
            }

            return NotFound("Items for this supplier are not found.");
        }

        [HttpGet("best-offer/{productId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<StoreItemOfferDTO>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetBestOffer(int productId, string criteria)
        {
            StoreItemOfferDTO bestOffer;

            if (criteria == nameof(OfferCriteria.Discount).ToLower())
            {
                bestOffer = await _statisticsService.GetBestOfferByDiscount(productId);
            }
            else if (criteria == nameof(OfferCriteria.Sales).ToLower())
            {
                bestOffer = await _statisticsService.GetBestOfferBySales(productId);
            }
            else
            {
                return BadRequest("Invalid criteria.");
            }

            if (bestOffer == null)
            {
                return NotFound("No offers found for the product.");
            }

            return Ok(bestOffer);
        }
    }
}
