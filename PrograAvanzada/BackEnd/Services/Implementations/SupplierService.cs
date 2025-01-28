using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class SupplierService : ISupplierService
    {
        private ISupplierDAL _supplierDAL;

        public SupplierService(ISupplierDAL supplierDAL)
        {
            _supplierDAL = supplierDAL;
        }
        public void AddSupplier(Supplier supplier)
        {
            _supplierDAL.AddSupplier(supplier);
        }

        public void DeleteSupplier(int id)
        {
            throw new NotImplementedException();
        }

        public List<Supplier> GetSuppliers()
        {
            throw new NotImplementedException();
        }

        public void UpdateSupplier(Supplier supplier)
        {
            throw new NotImplementedException();
        }
    }
}
