using inventory_blazor.Shared.Interfaces;
using inventory_blazor.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace inventory_blazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : BaseController
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public BrandController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpGet]
        public async Task<IEnumerable<Brand>> Get()
        {
            return await _dataAccessProvider.GetBrandsAsync();
        }

        [HttpGet("{id}")]
        public async Task<Brand> Get(int id)
        {
            return await _dataAccessProvider.GetBrandByIdAsync(id);
        }

        [HttpPost]
        public async Task Post([FromBody] Brand brand)
        {
            await _dataAccessProvider.AddBrandAsync(brand);
        }

        [HttpPut]
        public async Task Put([FromBody] Brand brand)
        {
            await _dataAccessProvider.UpdateBrandAsync(brand);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _dataAccessProvider.DeleteBrandAsync(id);
        }
    }
}
