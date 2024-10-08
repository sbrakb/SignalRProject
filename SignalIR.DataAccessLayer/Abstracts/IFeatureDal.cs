using SignalIR.EntityLayer.Entities;
using SignalR.DataAccessLayer.Repositories;

namespace SignalR.DataAccessLayer.Abstracts
{
    public interface IFeatureDal : IAsyncRepository<Feature>
    {
    }
}
