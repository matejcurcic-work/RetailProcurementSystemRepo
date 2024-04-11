namespace Database.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public int StoreItemId { get; set; }
        public StoreItem StoreItem { get; set; }

        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public int QuantitySold { get; set; }
        public decimal TotalAmount { get; set; } = 0;
        public DateTime SaleDate { get; set; } = DateTime.Now;
    }
}
