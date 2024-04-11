namespace RetailProcurementSystem.DTOs
{
    public record SupplierStoreItemDTO
    {
        public int StoreId { get; set; }
        public string StoreItemName { get; set; }
        public decimal StoreItemPrice { get; set; }
        public int StoreItemQuantity { get; set; }
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
    }
}
