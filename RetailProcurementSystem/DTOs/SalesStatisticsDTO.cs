namespace RetailProcurementSystem.DTOs
{
    public record SalesStatisticsDTO
    {
        public int StoreItemId { get; set; }
        public string StoreItemName { get; set; }
        public int QuantitySold { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
