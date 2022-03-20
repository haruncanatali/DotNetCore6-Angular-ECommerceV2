using ETicaretAPI.Application.Abstraction;
using ETicaretAPI.Application.Repositories.ProductRepository;
using ETicaretAPI.Domain.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;

        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Hello");
        }

        [HttpGet]
        [Route("products")]
        public async Task<IActionResult> GetProducts()
        {
            try
            {
                return Ok(await GetValuesFromFakeDb());
            }
            catch ( Exception e )
            {
                return BadRequest(new { e.Message });
            }
        }

        [HttpGet]
        [Route("getproduct")]
        public async Task<IActionResult> GetProduct(string productId)
        {
            try
            {
                return Ok(await _productReadRepository.GetByIdAsync(productId));
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }

        [HttpGet]
        [Route("update")]
        public async Task<IActionResult> UpdateProduct(string productId)
        {
            try
            {
                return Ok(await UpdateEntity(productId));
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }

        public async Task<IQueryable> GetValuesFromFakeDb()
        {
            var result  = await _productWriteRepository.AddRangeAsync(new()
            {
                new(){Id = Guid.NewGuid(),Name="Kalem",Price = 5,Stock = 100},
                new(){Id = Guid.NewGuid(),Name="Silgi",Price = 2, Stock = 100},
                new(){Id = Guid.NewGuid(),Name="Defter",Price = 15, Stock = 100},
                new(){Id = Guid.NewGuid(),Name="Kuru Boya",Price = 25, Stock = 100},
                new(){Id = Guid.NewGuid(),Name="Pastel Boya",Price = 30, Stock = 100},
                new(){Id = Guid.NewGuid(),Name="Cetvel",Price = 3, Stock = 100},
            });
            await _productWriteRepository.SaveAsync();
            var results = _productReadRepository.GetAll();
            return _productReadRepository.GetAll();
        }

        public async Task<Product> UpdateEntity(string id)
        {
            var result = await _productReadRepository.GetByIdAsync(id);
            result.Name = "Deneme";
            await _productWriteRepository.SaveAsync();
            return result;
        }
    }
}
