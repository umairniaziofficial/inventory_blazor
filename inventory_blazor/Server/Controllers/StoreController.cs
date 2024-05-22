using inventory_blazor.Shared.Interfaces;
using inventory_blazor.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace inventory_blazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : BaseController
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public StoreController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpGet]
        public async Task<IEnumerable<Store>> Get()
        {
            return await _dataAccessProvider.GetStoresAsync();
        }

        [HttpGet("{id}")]
        public async Task<Store> Get(int id)
        {
            return await _dataAccessProvider.GetStoreByIdAsync(id);
        }

        [HttpPost]
        public async Task Post([FromBody] Store store)
        {
            await _dataAccessProvider.AddStoreAsync(store);
        }

        [HttpPut]
        public async Task Put([FromBody] Store store)
        {
            await _dataAccessProvider.UpdateStoreAsync(store);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _dataAccessProvider.DeleteStoreAsync(id);
        }
    }
}
