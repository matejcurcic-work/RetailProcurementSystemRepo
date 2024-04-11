namespace Database.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IBAN { get; set; } = string.Empty;
        public string FullAddress { get; set; } = string.Empty;

        public ICollection<SupplierStoreItem>? SupplierStoreItems { get; set; }
    }
}
