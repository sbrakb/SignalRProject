using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalRWebUI.BusinessLayer.Dtos.Requests.Testimoinal;
using SignalRWebUI.BusinessLayer.Dtos.Responses.Testimoinal;

namespace SignalRWebUI.BusinessLayer.Profiles;

public class TestimoinalProfile : Profile
{
    public TestimoinalProfile()
    {
        CreateMap<CreateTestimoinalRequest, Testimoinal>().ReverseMap();
        CreateMap<Testimoinal, CreatedTestimoinalResponse>().ReverseMap();

        CreateMap<Testimoinal, DeletedTestimoinalResponse>().ReverseMap();

        CreateMap<Testimoinal, GetTestimoinalResponse>().ReverseMap();

        CreateMap<UpdateTestimoinalRequest, Testimoinal>().ReverseMap();
        CreateMap<Testimoinal, UpdatedTestimoinalResponse>().ReverseMap();
    }
}
