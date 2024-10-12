using SignalIR.EntityLayer.Entities;
using SignalRWebUI.DataAccessLayer.Abstracts;
using SignalRWebUI.DataAccessLayer.Contexts;
using SignalRWebUI.DataAccessLayer.Repositories;

namespace SignalRWebUI.DataAccessLayer.Concretes.EntityFramework;

public class EfContactDal : EfRepositoryBase<Contact>, IContactDal
{
    public EfContactDal(SignalRContext context) : base(context)
    {
    }
}
