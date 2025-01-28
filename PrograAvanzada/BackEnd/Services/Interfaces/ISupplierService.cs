using Entities.Entities;

namespace BackEnd.Services.Interfaces
{
    public interface ISupplierService
    {
        void AddSupplier(Supplier supplier);
        void UpdateSupplier(Supplier supplier);
        void DeleteSupplier(int id);
        List<Supplier> GetSuppliers();
    }
}
