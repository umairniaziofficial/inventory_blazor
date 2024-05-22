namespace inventory_blazor.Shared.Interfaces
{
    using inventory_blazor.Shared.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IDataAccessProvider
    {
        Task<IEnumerable<Brand>> GetBrandsAsync();
        Task<Brand> GetBrandByIdAsync(int id);
        Task AddBrandAsync(Brand brand);
        Task UpdateBrandAsync(Brand brand);
        Task DeleteBrandAsync(int id);

        Task<IEnumerable<Category>> GetCategoriesAsync();
        Task<Category> GetCategoryByIdAsync(int id);
        Task AddCategoryAsync(Category category);
        Task UpdateCategoryAsync(Category category);
        Task DeleteCategoryAsync(int id);

        Task<IEnumerable<Store>> GetStoresAsync();
        Task<Store> GetStoreByIdAsync(int id);
        Task AddStoreAsync(Store store);
        Task UpdateStoreAsync(Store store);
        Task DeleteStoreAsync(int id);

        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(int id);
    }
}
