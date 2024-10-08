using SignalIR.EntityLayer.Entities;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.DataAccessLayer.Contexts;
using SignalR.DataAccessLayer.Repositories;

namespace SignalR.DataAccessLayer.Concretes.EntityFramework;

public class EfContactDal : EfRepositoryBase<Contact>, IContactDal
{
    public EfContactDal(SignalRContext context) : base(context)
    {
    }
}
