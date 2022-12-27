using Microsoft.AspNetCore.Mvc;
using OpenFood.Application.Interfaces;

namespace OpenFood.Servies.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Fullstack Challenge 20201026");
        }

        [HttpGet("products/{id:int}")]
        public IActionResult GetProduct(int id)
        {
            if (id <= 0)
                return NotFound();

            var result = _productService.GetById(id);
            return result == null ? NotFound() : new JsonResult(result);
        }

        [HttpGet("products")]
        public IActionResult GetProducts()
        {
            var result = _productService.GetAll();
            return result == null ? NotFound() : new JsonResult(result);
        }
    }
}
