using inventory_blazor.Shared.Interfaces;
using inventory_blazor.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace inventory_blazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseController
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public ProductController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _dataAccessProvider.GetProductsAsync();
        }

        [HttpGet("{id}")]
        public async Task<Product> Get(int id)
        {
            return await _dataAccessProvider.GetProductByIdAsync(id);
        }

        [HttpPost]
        public async Task Post([FromBody] Product product)
        {
            await _dataAccessProvider.AddProductAsync(product);
        }

        [HttpPut]
        public async Task Put([FromBody] Product product)
        {
            await _dataAccessProvider.UpdateProductAsync(product);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _dataAccessProvider.DeleteProductAsync(id);
        }
    }
}
