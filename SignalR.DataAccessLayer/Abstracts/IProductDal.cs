using SignalIR.EntityLayer.Entities;
using SignalRWebUI.DataAccessLayer.Repositories;

namespace SignalRWebUI.DataAccessLayer.Abstracts
{
    public interface IProductDal : IAsyncRepository<Product>
    {
        Task<List<Product>> GetProductsWithCategories();
    }
}
