using SignalIR.EntityLayer.Entities;
using SignalRWebUI.DataAccessLayer.Abstracts;
using SignalRWebUI.DataAccessLayer.Contexts;
using SignalRWebUI.DataAccessLayer.Repositories;

namespace SignalRWebUI.DataAccessLayer.Concretes.EntityFramework;

public class EfFeatureDal : EfRepositoryBase<Feature>, IFeatureDal
{
    public EfFeatureDal(SignalRContext context) : base(context)
    {
    }
}
