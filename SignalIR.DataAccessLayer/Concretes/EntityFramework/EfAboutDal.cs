using SignalIR.EntityLayer.Entities;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.DataAccessLayer.Contexts;
using SignalR.DataAccessLayer.Repositories;

namespace SignalR.DataAccessLayer.Concretes.EntityFramework;

public class EfAboutDal : EfRepositoryBase<About>, IAboutDal
{
    public EfAboutDal(SignalRContext context) : base(context)
    {

    }
}
