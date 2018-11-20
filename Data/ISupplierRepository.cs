using System.Collections.Generic;
using ApiDesign.Models;

namespace ApiDesign.Data
{
    public interface ISupplierRepository
    {
         List<Supplier> GetSuppliers();
         Supplier GetSupplier(int id);
         void AddSupplier(Supplier supplier);
         void UpdateSupplier(Supplier supplier);
         void DeleteSupplier(Supplier supplier);
    }
}