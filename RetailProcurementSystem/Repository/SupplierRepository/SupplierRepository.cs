using Database.Context;
using Database.Models;

namespace RetailProcurementSystem.Repository.SupplierRepository
{
    public class SupplierRepository : GenericRepository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(ApplicationDbContext context) : base(context)
        {

        }
    }

}
