using DAL.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class UnidadDeTrabajo : IUnidadDeTrabajo
    {
        public ISupplierDAL SupplierDAL { get; set; }

        private NorthwndContext _northwndContext;

        public UnidadDeTrabajo(NorthwndContext northwndContext, ISupplierDAL supplierDAL )
        {
            this._northwndContext = northwndContext;
            this.SupplierDAL = supplierDAL;
            
        }

        public bool Complete()
        {
            try
            {
                _northwndContext.SaveChanges();
                return true;
            }
            catch (Exception ex) { 
                return false;
            }
        }

        public void Dispose()
        {
            this._northwndContext.Dispose();
        }
    }
}
