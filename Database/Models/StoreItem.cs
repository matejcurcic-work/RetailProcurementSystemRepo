namespace Database.Models
{
    public class StoreItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int? Discount { get; set; }

        public ICollection<SupplierStoreItem>? SupplierStoreItems { get; set; }

    }
}
