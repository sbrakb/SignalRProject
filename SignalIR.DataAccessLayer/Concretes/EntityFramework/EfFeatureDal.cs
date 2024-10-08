using SignalIR.EntityLayer.Entities;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.DataAccessLayer.Contexts;
using SignalR.DataAccessLayer.Repositories;

namespace SignalR.DataAccessLayer.Concretes.EntityFramework;

public class EfFeatureDal : EfRepositoryBase<Feature>, IFeatureDal
{
    public EfFeatureDal(SignalRContext context) : base(context)
    {
    }
}
