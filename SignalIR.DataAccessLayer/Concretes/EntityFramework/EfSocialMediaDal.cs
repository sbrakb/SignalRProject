using SignalIR.EntityLayer.Entities;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.DataAccessLayer.Contexts;
using SignalR.DataAccessLayer.Repositories;

namespace SignalR.DataAccessLayer.Concretes.EntityFramework;

public class EfSocialMediaDal : EfRepositoryBase<SocialMedia>, ISocialMediaDal
{
    public EfSocialMediaDal(SignalRContext context) : base(context)
    {
    }
}
