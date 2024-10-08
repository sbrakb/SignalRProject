using SignalIR.EntityLayer.Entities;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.DataAccessLayer.Contexts;
using SignalR.DataAccessLayer.Repositories;

namespace SignalR.DataAccessLayer.Concretes.EntityFramework;

public class EfTestimoinalDal : EfRepositoryBase<Testimoinal>, ITestimoinalDal
{
    public EfTestimoinalDal(SignalRContext context) : base(context)
    {
    }
}
