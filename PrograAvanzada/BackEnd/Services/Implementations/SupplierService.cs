using BackEnd.Services.Interfaces;
using DAL.Implementations;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class SupplierService : ISupplierService
    {
        IUnidadDeTrabajo _unidadDeTrabajo;

        public SupplierService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }
        public void AddSupplier(Supplier supplier)
        {
            _unidadDeTrabajo.SupplierDAL.Add(supplier);
            _unidadDeTrabajo.Complete();
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
