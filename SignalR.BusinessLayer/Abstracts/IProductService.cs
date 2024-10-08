using SignalIR.EntityLayer.Entities;
using SignalR.BusinessLayer.Dtos.Requests.Product;
using SignalR.BusinessLayer.Dtos.Responses.Product;

namespace SignalR.BusinessLayer.Abstracts;

public interface IProductService
{
    Task<List<GetProductResponse>> GetListAsync();
    Task<GetProductResponse> GetAsync(GetProductRequest getProductRequest);
    Task<CreatedProductResponse> AddAsync(CreateProductRequest createProductRequest);
    Task<UpdatedProductResponse> UpdateAsync(int id, UpdateProductRequest updateProductRequest);
    Task<DeletedProductResponse> DeleteAsync(DeleteProductRequest deleteProductRequest);
    Task<List<GetProductWithCategoryNameResponse>> GetProductsWithCategories();
}


