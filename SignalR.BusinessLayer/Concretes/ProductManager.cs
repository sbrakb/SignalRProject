using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalR.BusinessLayer.Abstracts;
using SignalR.BusinessLayer.Dtos.Requests.Product;
using SignalR.BusinessLayer.Dtos.Responses.Product;
using SignalR.DataAccessLayer.Abstracts;

namespace SignalR.BusinessLayer.Concretes;

public class ProductManager : IProductService
{
    private readonly IProductDal _productDal;
    private readonly IMapper _mapper;
    public ProductManager(IProductDal productDal, IMapper mapper)
    {
        _productDal = productDal;
        _mapper = mapper;
    }

    public async Task<CreatedProductResponse> AddAsync(CreateProductRequest createProductRequest)
    {
        Product product = _mapper.Map<Product>(createProductRequest);
        await _productDal.AddAsync(product);
        CreatedProductResponse createdProductResponse = _mapper.Map<CreatedProductResponse>(product);
        return createdProductResponse;
    }

    public async Task<DeletedProductResponse> DeleteAsync(DeleteProductRequest deleteProductRequest)
    {
        Product product = await _productDal.GetAsync(deleteProductRequest.Id);
        await _productDal.DeleteAsync(product);
        DeletedProductResponse deletedProductResponse = _mapper.Map<DeletedProductResponse>(product);
        return deletedProductResponse;
    }

    public async Task<GetProductResponse> GetAsync(GetProductRequest getProductRequest)
    {
        Product product = await _productDal.GetAsync(getProductRequest.Id);
        GetProductResponse getProductResponse = _mapper.Map<GetProductResponse>(product);
        return getProductResponse;
    }

    public async Task<List<GetProductResponse>> GetListAsync()
    {
        List<Product> products = await _productDal.GetListAsync();
        List<GetProductResponse> getProductResponses = _mapper.Map<List<GetProductResponse>>(products);
        return getProductResponses;
    }

    public async Task<List<GetProductWithCategoryNameResponse>> GetProductsWithCategories()
    {
        List<Product> products = await _productDal.GetProductsWithCategories();
        List<GetProductWithCategoryNameResponse> getProductWithCategoryNameResponses = _mapper.Map<List<GetProductWithCategoryNameResponse>>(products);
        return getProductWithCategoryNameResponses;
    }

    public async Task<UpdatedProductResponse> UpdateAsync(int id, UpdateProductRequest updateProductRequest)
    {
        Product product = await _productDal.GetAsync(id);
        _mapper.Map(updateProductRequest, product);
        await _productDal.UpdateAsync(product);
        UpdatedProductResponse updatedProductResponse = _mapper.Map<UpdatedProductResponse>(product);
        return updatedProductResponse;
    }
}