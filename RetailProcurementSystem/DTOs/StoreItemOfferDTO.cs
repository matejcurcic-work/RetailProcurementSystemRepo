namespace RetailProcurementSystem.DTOs
{
    public record StoreItemOfferDTO
    {
        public int StoreItemId { get; set; }
        public string StoreItemName { get; set; }
        public int Discount { get; set; }
        public int TotalQuantitySold { get; set; }
    }
}
