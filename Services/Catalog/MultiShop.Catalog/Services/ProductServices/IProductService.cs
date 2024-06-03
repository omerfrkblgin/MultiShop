

using MultiShop.Catalog.Dtos.ProductDtos;

namespace MultiShop.Catalog.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductsAsync();
        Task CreateProductsAsync(CreateProductDto createProductDto);
        Task UpdateProductsAsync(UpdateProductDto updateProductDto);
        Task DeleteProductsAsync(string id);
        Task<GetByIdProductDto> GetByIdProductAsync(string id);
    }
}
