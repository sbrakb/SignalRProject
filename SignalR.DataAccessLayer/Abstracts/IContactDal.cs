using SignalIR.EntityLayer.Entities;
using SignalRWebUI.DataAccessLayer.Repositories;

namespace SignalRWebUI.DataAccessLayer.Abstracts
{
    public interface IContactDal : IAsyncRepository<Contact>
    {
    }
}
