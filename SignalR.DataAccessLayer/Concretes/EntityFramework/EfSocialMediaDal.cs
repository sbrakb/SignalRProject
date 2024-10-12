using SignalIR.EntityLayer.Entities;
using SignalRWebUI.DataAccessLayer.Abstracts;
using SignalRWebUI.DataAccessLayer.Contexts;
using SignalRWebUI.DataAccessLayer.Repositories;

namespace SignalRWebUI.DataAccessLayer.Concretes.EntityFramework;

public class EfSocialMediaDal : EfRepositoryBase<SocialMedia>, ISocialMediaDal
{
    public EfSocialMediaDal(SignalRContext context) : base(context)
    {
    }
}
