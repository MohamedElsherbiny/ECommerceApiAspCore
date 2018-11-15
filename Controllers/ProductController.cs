using System.Threading.Tasks;
using ApiDesign.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiDesign.Extentions;
using ApiDesign.Data;
using AutoMapper;
using System.Collections.Generic;
using ApiDesign.Dtos;

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
    }
}