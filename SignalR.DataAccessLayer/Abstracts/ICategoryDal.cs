using SignalIR.EntityLayer.Entities;
using SignalRWebUI.DataAccessLayer.Repositories;

namespace SignalRWebUI.DataAccessLayer.Abstracts
{
    public interface ICategoryDal : IAsyncRepository<Category>
    {
    }
}
