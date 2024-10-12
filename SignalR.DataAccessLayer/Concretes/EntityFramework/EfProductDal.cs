using Microsoft.EntityFrameworkCore;
using SignalIR.EntityLayer.Entities;
using SignalRWebUI.DataAccessLayer.Abstracts;
using SignalRWebUI.DataAccessLayer.Contexts;
using SignalRWebUI.DataAccessLayer.Repositories;

namespace SignalRWebUI.DataAccessLayer.Concretes.EntityFramework;

public class EfProductDal : EfRepositoryBase<Product>, IProductDal
{
    SignalRContext _context;
    public EfProductDal(SignalRContext context) : base(context)
    {
        _context = context;
    }

    public async Task<List<Product>> GetProductsWithCategories()
    {

        var result = await _context.Products.Include(p => p.Category).ToListAsync();

        return result;
    }
}
