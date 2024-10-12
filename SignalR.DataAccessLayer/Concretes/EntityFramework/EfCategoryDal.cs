using SignalIR.EntityLayer.Entities;
using SignalRWebUI.DataAccessLayer.Abstracts;
using SignalRWebUI.DataAccessLayer.Contexts;
using SignalRWebUI.DataAccessLayer.Repositories;

namespace SignalRWebUI.DataAccessLayer.Concretes.EntityFramework;

public class EfCategoryDal : EfRepositoryBase<Category>, ICategoryDal
{
    public EfCategoryDal(SignalRContext context) : base(context)
    {
    }
}
