using Dapper;
using Database.Context;
using Database.Models;
using RetailProcurementSystem.DTOs;
using RetailProcurementSystem.Repository.SupplierStoreItemRepository;

namespace RetailProcurementSystem.Services.SupplierStoreItemService
{
    public class SupplierStoreItemService : ISupplierStoreItemService
    {
        private readonly ISupplierStoreItemRepository _supplierStoreItemRepository;
        private readonly DapperContext _dapperContext;


        public SupplierStoreItemService(ISupplierStoreItemRepository supplierStoreItemRepository, DapperContext dapperContext)
        {
            _supplierStoreItemRepository = supplierStoreItemRepository;
            _dapperContext = dapperContext;
        }

        public async Task<List<SupplierStoreItemDTO>> GetAllSupplierStoreItems()
        {
            string query = @"
                SELECT 
                    si.Id AS StoreId,
                    si.Name AS StoreItemName,
                    si.Price AS StoreItemPrice,
                    si.Quantity AS StoreItemQuantity,
                    sup.Id AS SupplierId,
                    sup.Name AS SupplierName
                FROM SupplierStoreItems ssi
                INNER JOIN StoreItems si ON ssi.StoreId = si.Id
                INNER JOIN Suppliers sup ON ssi.SupplierId = sup.Id
            ";


            using var connection = _dapperContext.CreateConnection();
            var getAll = await connection.QueryAsync<SupplierStoreItemDTO>(query);
            return getAll.ToList();

        }

        public async Task<bool> InsertNewStoreItem(int supplierId, int storeId)
        {
            bool exists = await SupplierStoreItemExists(supplierId, storeId);

            if (exists)
            {
                return false;
            }

            var supplierStoreItem = new SupplierStoreItem() { SupplierId = supplierId, StoreId = storeId };

            await _supplierStoreItemRepository.AddAsync(supplierStoreItem);

            return true;
        }


        public async Task<bool> DeleteStoreItem(int supplierId, int storeId)
        {
            var exists = await SupplierStoreItemExists(supplierId, storeId);
            if (exists)
            {
                var supplierStoreItem = new SupplierStoreItem() { SupplierId = supplierId, StoreId = storeId };

                await _supplierStoreItemRepository.DeleteAsync(supplierStoreItem);


                return true;
            }

            return false;
        }


        private async Task<bool> SupplierStoreItemExists(int supplierId, int storeId)
        {

            var exists = await _supplierStoreItemRepository.SupplierStoreItemExistsAsync(supplierId, storeId);

            return exists;
        }
    }
}