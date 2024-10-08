using Microsoft.EntityFrameworkCore;
using SignalIR.EntityLayer.Entities;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.DataAccessLayer.Contexts;
using SignalR.DataAccessLayer.Repositories;

namespace SignalR.DataAccessLayer.Concretes.EntityFramework;

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
