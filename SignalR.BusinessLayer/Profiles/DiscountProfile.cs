using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalRWebUI.BusinessLayer.Dtos.Requests.Discount;
using SignalRWebUI.BusinessLayer.Dtos.Responses.Discount;

namespace SignalRWebUI.BusinessLayer.Profiles;

public class DiscountProfile : Profile
{
    public DiscountProfile()
    {
        CreateMap<CreateDiscountRequest, Discount>().ReverseMap();
        CreateMap<Discount, CreatedDiscountResponse>().ReverseMap();

        CreateMap<Discount, DeletedDiscountResponse>().ReverseMap();

        CreateMap<Discount, GetDiscountResponse>().ReverseMap();

        CreateMap<UpdateDiscountRequest, Discount>().ReverseMap();
        CreateMap<Discount, UpdatedDiscountResponse>().ReverseMap();
    }
}
