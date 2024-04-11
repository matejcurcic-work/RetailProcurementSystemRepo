using Database.Context;
using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace RetailProcurementSystem.Repository.SupplierStoreItemRepository
{
    public class SupplierStoreItemRepository : GenericRepository<SupplierStoreItem>, ISupplierStoreItemRepository
    {
        private readonly ApplicationDbContext _context;
        public SupplierStoreItemRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<bool> SupplierStoreItemExistsAsync(int supplierId, int storeId)
        {
            return await _context.Set<SupplierStoreItem>().Include(x => x.Supplier).Include(x => x.StoreItem)
                .AnyAsync(ssi => ssi.SupplierId == supplierId && ssi.StoreId == storeId);
        }
    }
}
