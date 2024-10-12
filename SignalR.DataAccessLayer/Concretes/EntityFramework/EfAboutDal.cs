using SignalIR.EntityLayer.Entities;
using SignalRWebUI.DataAccessLayer.Abstracts;
using SignalRWebUI.DataAccessLayer.Contexts;
using SignalRWebUI.DataAccessLayer.Repositories;

namespace SignalRWebUI.DataAccessLayer.Concretes.EntityFramework;

public class EfAboutDal : EfRepositoryBase<About>, IAboutDal
{
    public EfAboutDal(SignalRContext context) : base(context)
    {

    }
}
