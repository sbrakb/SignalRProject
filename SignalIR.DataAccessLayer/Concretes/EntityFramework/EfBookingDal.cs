using SignalIR.EntityLayer.Entities;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.DataAccessLayer.Contexts;
using SignalR.DataAccessLayer.Repositories;

namespace SignalR.DataAccessLayer.Concretes.EntityFramework;

public class EfBookingDal : EfRepositoryBase<Booking>, IBookingDal
{
    public EfBookingDal(SignalRContext context) : base(context)
    {
    }
}
