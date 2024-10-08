using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalR.BusinessLayer.Dtos.Requests.Feature;
using SignalR.BusinessLayer.Dtos.Responses.Feature;

namespace SignalR.BusinessLayer.Profiles;

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
