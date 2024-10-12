using SignalIR.EntityLayer.Entities;
using SignalRWebUI.DataAccessLayer.Abstracts;
using SignalRWebUI.DataAccessLayer.Contexts;
using SignalRWebUI.DataAccessLayer.Repositories;

namespace SignalRWebUI.DataAccessLayer.Concretes.EntityFramework;

public class EfDiscountDal : EfRepositoryBase<Discount>, IDiscountDal
{
    public EfDiscountDal(SignalRContext context) : base(context)
    {
    }
}
