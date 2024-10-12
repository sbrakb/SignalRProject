using SignalIR.EntityLayer.Entities;
using SignalRWebUI.DataAccessLayer.Abstracts;
using SignalRWebUI.DataAccessLayer.Contexts;
using SignalRWebUI.DataAccessLayer.Repositories;

namespace SignalRWebUI.DataAccessLayer.Concretes.EntityFramework;

public class EfBookingDal : EfRepositoryBase<Booking>, IBookingDal
{
    public EfBookingDal(SignalRContext context) : base(context)
    {
    }
}
