using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalR.BusinessLayer.Dtos.Requests.SocialMedia;
using SignalR.BusinessLayer.Dtos.Responses.SocialMedia;

namespace SignalR.BusinessLayer.Profiles;

public class SocialMediaProfile : Profile
{
    public SocialMediaProfile()
    {
        CreateMap<CreateSocialMediaRequest, SocialMedia>().ReverseMap();
        CreateMap<SocialMedia, CreatedSocialMediaResponse>().ReverseMap();

        CreateMap<SocialMedia, DeletedSocialMediaResponse>().ReverseMap();

        CreateMap<SocialMedia, GetSocialMediaResponse>().ReverseMap();

        CreateMap<UpdateSocialMediaRequest, SocialMedia>().ReverseMap();
        CreateMap<SocialMedia, UpdatedSocialMediaResponse>().ReverseMap();
    }
}
