using ApiDesign.Data;
using ApiDesign.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiDesign.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _repo;

        public CategoryController(ICategoryRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repo.GetCategorys());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var categoryFromRepo = _repo.GetCategory(id);
            if (categoryFromRepo == null)
                return StatusCode((int)System.Net.HttpStatusCode.NotFound);
            
            return Ok(categoryFromRepo);
        }
         [HttpPost("Update")]
        public IActionResult Update([FromBody]Category category)
        {
            if(!ModelState.IsValid)
                return StatusCode((int)System.Net.HttpStatusCode.BadRequest);

            var categoryFromRepo = _repo.GetCategory(category.Id);
            if (categoryFromRepo == null)
                return StatusCode((int)System.Net.HttpStatusCode.NotFound);

            _repo.UpdateCategory(category);
            
            return Ok();
        }
        [HttpPost("Add")]
        public IActionResult Add([FromBody]Category category)
        {
            var categoryFromRepo = _repo.GetCategory(category.Id);
            if (categoryFromRepo != null)
                return StatusCode((int)System.Net.HttpStatusCode.Found);
            
            _repo.AddCategory(category);
            return Ok((int)System.Net.HttpStatusCode.Created);
            
        }
        [HttpPost("Delete/{id}")]
        public IActionResult Delete(int id)
        {

            var categoryFromRepo = _repo.GetCategory(id);
            if (categoryFromRepo == null)
                return StatusCode((int)System.Net.HttpStatusCode.Found);
            
            _repo.DeleltCategory(categoryFromRepo);
            
            return Ok();
        }

    }
}