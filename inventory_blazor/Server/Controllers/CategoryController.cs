using inventory_blazor.Shared.Interfaces;
using inventory_blazor.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace inventory_blazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : BaseController
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public CategoryController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> Get()
        {
            return await _dataAccessProvider.GetCategoriesAsync();
        }

        [HttpGet("{id}")]
        public async Task<Category> Get(int id)
        {
            return await _dataAccessProvider.GetCategoryByIdAsync(id);
        }

        [HttpPost]
        public async Task Post([FromBody] Category category)
        {
            await _dataAccessProvider.AddCategoryAsync(category);
        }

        [HttpPut]
        public async Task Put([FromBody] Category category)
        {
            await _dataAccessProvider.UpdateCategoryAsync(category);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _dataAccessProvider.DeleteCategoryAsync(id);
        }
    }
}
