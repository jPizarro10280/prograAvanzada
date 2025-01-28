using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public class SupplierDAL : ISupplierDAL
    {
        private NorthwndContext _context;
        public SupplierDAL(NorthwndContext context)
        {
            _context = context;
        }
        public bool AddSupplier(Supplier supplier)
        {
            try
            {
                _context.Add(supplier);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteSupplier(int id)
        {
            throw new NotImplementedException();
        }

        public List<Supplier> GetSuppliers()
        {
            throw new NotImplementedException();
        }

        public bool UpdateSupplier(Supplier supplier)
        {
            throw new NotImplementedException();
        }
    }
}
