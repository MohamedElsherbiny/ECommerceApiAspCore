using ApiDesign.Data;
using ApiDesign.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiDesign.Controllers
{
    [Route("api/[controller]")]
    public class SupplierController : Controller
    {
        private readonly ISupplierRepository _repo;

        public SupplierController(ISupplierRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repo.GetSuppliers());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var supplierFromRepo = _repo.GetSupplier(id);
            if (supplierFromRepo == null)
                return StatusCode((int)System.Net.HttpStatusCode.NotFound);
            
            return Ok(supplierFromRepo);
        }
         [HttpPost("Update")]
        public IActionResult Update([FromBody]Supplier supplier)
        {
            if(!ModelState.IsValid)
                return StatusCode((int)System.Net.HttpStatusCode.BadRequest);

            var supplierFromRepo = _repo.GetSupplier(supplier.Id);
            if (supplierFromRepo == null)
                return StatusCode((int)System.Net.HttpStatusCode.NotFound);

            _repo.UpdateSupplier(supplier);
            
            return Ok();
        }
        [HttpPost("Add")]
        public IActionResult Add([FromBody]Supplier supplier)
        {
            var supplierFromRepo = _repo.GetSupplier(supplier.Id);
            if (supplierFromRepo != null)
                return StatusCode((int)System.Net.HttpStatusCode.Found);
            
            _repo.AddSupplier(supplier);
            return Ok((int)System.Net.HttpStatusCode.Created);
            
        }
        [HttpPost("Delete/{id}")]
        public IActionResult Delete(int id)
        {

            var supplierFromRepo = _repo.GetSupplier(id);
            if (supplierFromRepo == null)
                return StatusCode((int)System.Net.HttpStatusCode.Found);
            
            _repo.DeleteSupplier(supplierFromRepo);
            
            return Ok();
        }
    }
}