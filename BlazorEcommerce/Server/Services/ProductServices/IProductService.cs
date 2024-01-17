namespace BlazorEcommerce.Server.Services.ProductServices
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductAsync();
        Task<ServiceResponse<Product>> GetProductAsync(int productId);
    }
}
