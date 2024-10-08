using SignalIR.EntityLayer.Entities;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.DataAccessLayer.Contexts;
using SignalR.DataAccessLayer.Repositories;

namespace SignalR.DataAccessLayer.Concretes.EntityFramework;

public class EfDiscountDal : EfRepositoryBase<Discount>, IDiscountDal
{
    public EfDiscountDal(SignalRContext context) : base(context)
    {
    }
}
