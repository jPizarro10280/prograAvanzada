using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ISupplierDAL
    {
        bool AddSupplier(Supplier supplier);
        bool UpdateSupplier(Supplier supplier);
        bool DeleteSupplier(int id);
        List<Supplier> GetSuppliers();

    }
}
