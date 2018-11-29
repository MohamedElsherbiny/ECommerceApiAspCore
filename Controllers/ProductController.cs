using System.Threading.Tasks;
using ApiDesign.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiDesign.Extentions;
using ApiDesign.Data;
using AutoMapper;
using System.Collections.Generic;
using ApiDesign.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace ApiDesign.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller 
    {
        private readonly IProductRepository _repo;
        private readonly IMapper _mapper;

        public ProductController(IProductRepository repo,IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var productsFromRepo = _repo.GetProducts();
            var productsToReturn = _mapper.Map<List<ProductForListDto>>(productsFromRepo);
            return Ok(productsToReturn);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var productFromRepo = _repo.GetProduct(id);
            var productToReturn = _mapper.Map<ProductForDetailDto>(productFromRepo);
            return Ok(productToReturn);
        }
        [HttpPost("Add")]
        public IActionResult Add([FromBody]ProductForAddingDto productForAddingDto)
        {
            if (!ModelState.IsValid)
                return Unauthorized();

            var product = _mapper.Map<Product>(productForAddingDto);
            _repo.AddProduct(product);
            
            return Ok(201);
        }
        [HttpPost("Update")]
        public IActionResult Update([FromBody]ProductForUpdateDto productForUpdatingDto)
        {
            if (!ModelState.IsValid)
                return Unauthorized();

            var product = _mapper.Map<Product>(productForUpdatingDto);
            _repo.UpdateProduct(product);

            return Ok(201);
        }
        [HttpPost("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            _repo.DeleteProduct(id);

            return Ok(201);
        }
    }
}