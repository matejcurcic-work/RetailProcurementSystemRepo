using Bogus;
using Database.Models;

namespace Database.Seed
{
    public class DatabaseSeeder
    {
        public IReadOnlyCollection<StoreItem> StoreItems { get; } = new List<StoreItem>();
        public IReadOnlyCollection<Supplier> Suppliers { get; } = new List<Supplier>();
        public IReadOnlyCollection<SupplierStoreItem> SupplierStoreItems { get; } = new List<SupplierStoreItem>();
        public IReadOnlyCollection<SalesRecord> SalesRecords { get; } = new List<SalesRecord>();


        public DatabaseSeeder()
        {
            StoreItems = GenerateStoreItems(amount: 50);
            Suppliers = GenerateSuppliers(amount: 10);
            SupplierStoreItems = GenerateSupplierStoreItems(amount: 50, StoreItems, Suppliers);
            SalesRecords = GetSalesRecords(amount: 50, StoreItems, Suppliers);
        }



        private static IReadOnlyCollection<Supplier> GenerateSuppliers(int amount)
        {
            var supplierId = 1;

            var supplierFaker = new Faker<Supplier>()
                .RuleFor(s => s.Id, f => supplierId++)
                .RuleFor(s => s.Name, f => f.Company.CompanyName())
                .RuleFor(s => s.IBAN, f => f.Random.Replace("HR##########"))
                .RuleFor(s => s.FullAddress, f => f.Address.FullAddress());

            var storeItems = Enumerable.Range(1, amount)
                .Select(i => SeedRow(supplierFaker, i))
                .ToList();

            return storeItems;
        }

        private static IReadOnlyCollection<StoreItem> GenerateStoreItems(int amount)
        {
            var storeItemId = 1;

            var storeItemFaker = new Faker<StoreItem>()
                .RuleFor(s => s.Id, f => storeItemId++)
                .RuleFor(s => s.Name, f => f.Commerce.Product())
                .RuleFor(s => s.Description, f => f.Lorem.Word())
                .RuleFor(s => s.Quantity, f => f.Random.Int(1, 500))
                .RuleFor(s => s.Price, f => f.Random.Decimal(1, 2))
                .RuleFor(s => s.Discount, f => f.Random.Int(0, 30));


            var storeItems = Enumerable.Range(1, amount)
                .Select(i => SeedRow(storeItemFaker, i))
                .ToList();

            return storeItems;
        }

        private static IReadOnlyCollection<SalesRecord> GetSalesRecords(int amount, IEnumerable<StoreItem> storeItems, IEnumerable<Supplier> suppliers)
        {
            var recordId = 1;

            var recordFaker = new Faker<SalesRecord>()
                .RuleFor(s => s.Id, f => recordId++)
                .RuleFor(s => s.StoreItemId, f => f.PickRandom(storeItems).Id)
                .RuleFor(s => s.SupplierId, f => f.PickRandom(suppliers).Id)
                .RuleFor(s => s.QuantitySold, f => f.Random.Number(1, 100))
                .RuleFor(s => s.TotalAmount, f => f.Random.Decimal(10, 500))
                .RuleFor(s => s.SaleDate, f => f.Date.Between(DateTime.Now.AddYears(-1), DateTime.Now));

            var salesRecords = Enumerable.Range(1, amount)
                .Select(i => SeedRow(recordFaker, i))
                .ToList();

            return salesRecords;
        }



        private static IReadOnlyCollection<SupplierStoreItem> GenerateSupplierStoreItems(int amount, IEnumerable<StoreItem> storeItems, IEnumerable<Supplier> suppliers)
        {
            var supplierStoreItemFaker = new Faker<SupplierStoreItem>()
            .RuleFor(x => x.SupplierId, f => f.PickRandom(suppliers).Id)
            .RuleFor(x => x.StoreId, f => f.PickRandom(storeItems).Id);


            var productProductCategories = Enumerable.Range(1, amount)
            .Select(i => SeedRow(supplierStoreItemFaker, i))
            .GroupBy(x => new { x.SupplierId, x.StoreId })
            .Select(x => x.First())
            .ToList();

            return productProductCategories;
        }


        private static T SeedRow<T>(Faker<T> faker, int rowId) where T : class
        {
            var recordRow = faker.UseSeed(rowId).Generate();
            return recordRow;
        }
    }
}
