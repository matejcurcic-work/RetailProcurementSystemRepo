namespace Database.Models
{
    public class SupplierStoreItem
    {
        public int StoreId { get; set; }
        public StoreItem StoreItem { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }
}
