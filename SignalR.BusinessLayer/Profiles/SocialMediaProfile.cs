using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalRWebUI.BusinessLayer.Dtos.Requests.SocialMedia;
using SignalRWebUI.BusinessLayer.Dtos.Responses.SocialMedia;

namespace SignalRWebUI.BusinessLayer.Profiles;

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
