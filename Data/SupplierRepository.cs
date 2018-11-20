using System.Collections.Generic;
using System.Linq;
using ApiDesign.Models;

namespace ApiDesign.Data
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly AppDbContext _context;

        public SupplierRepository(AppDbContext context)
        {
            _context = context;
        }
        public void AddSupplier(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
        }

        public void DeleteSupplier(Supplier supplier)
        {
            _context.Suppliers.Remove(supplier);
            _context.SaveChanges();
        }

        public Supplier GetSupplier(int id)
        {
            return _context.Suppliers.FirstOrDefault(x => x.Id == id);
        }

        public List<Supplier> GetSuppliers()
        {
            return _context.Suppliers.ToList();
        }

        public void UpdateSupplier(Supplier supplier)
        {
            var supplierFromRepo = _context.Suppliers.FirstOrDefault(x => x.Id == supplier.Id);
            if(supplierFromRepo != null)
            {
                supplierFromRepo.CompanyName =   supplier.CompanyName;
                supplierFromRepo.ContactName =   supplier.ContactName;
                supplierFromRepo.ContactTitle =  supplier.ContactTitle;
                supplierFromRepo.Address =       supplier.Address;
                supplierFromRepo.City =          supplier.City;
                supplierFromRepo.PostalCode =    supplier.PostalCode;
                supplierFromRepo.Country =       supplier.Country;
                supplierFromRepo.Phone =         supplier.Phone;
                supplierFromRepo.Products =      supplier.Products;
                _context.Suppliers.Update(supplierFromRepo);
                _context.SaveChanges();
            }
        }
    }
}