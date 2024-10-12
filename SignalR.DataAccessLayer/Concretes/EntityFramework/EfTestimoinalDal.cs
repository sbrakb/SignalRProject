using SignalIR.EntityLayer.Entities;
using SignalRWebUI.DataAccessLayer.Abstracts;
using SignalRWebUI.DataAccessLayer.Contexts;
using SignalRWebUI.DataAccessLayer.Repositories;

namespace SignalRWebUI.DataAccessLayer.Concretes.EntityFramework;

public class EfTestimoinalDal : EfRepositoryBase<Testimoinal>, ITestimoinalDal
{
    public EfTestimoinalDal(SignalRContext context) : base(context)
    {
    }
}
