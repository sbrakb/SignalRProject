using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalRWebUI.BusinessLayer.Dtos.Requests.Feature;
using SignalRWebUI.BusinessLayer.Dtos.Responses.Feature;

namespace SignalRWebUI.BusinessLayer.Profiles;

public class FeatureProfile : Profile
{
    public FeatureProfile()
    {
        CreateMap<CreateFeatureRequest, Feature>().ReverseMap();
        CreateMap<Feature, CreatedFeatureResponse>().ReverseMap();

        CreateMap<Feature, DeletedFeatureResponse>().ReverseMap();

        CreateMap<Feature, GetFeatureResponse>().ReverseMap();

        CreateMap<UpdateFeatureRequest, Feature>().ReverseMap();
        CreateMap<Feature, UpdatedFeatureResponse>().ReverseMap();
    }
}
