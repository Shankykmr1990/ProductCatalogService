using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductCatalogService.Models;
using ProductCatalogService.Services;

namespace ProductCatalogService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _service;

        public ProductsController(ProductService service)
        {
            _service = service;
        }
        
        [HttpGet]
        public IActionResult GetAll()=>Ok(_service.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetbyId(int id)
        {
            var product = _service.GetById(id);
            return product==null? NotFound() : Ok(product);
        }

        [HttpPost]
        public IActionResult Create(Products product)
        {
            _service.Add(product);
            return CreatedAtAction(nameof(GetbyId), new { id = product.Id }, product);
        }
    }
}
