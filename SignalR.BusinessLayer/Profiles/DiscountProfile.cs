using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalR.BusinessLayer.Dtos.Requests.Discount;
using SignalR.BusinessLayer.Dtos.Responses.Discount;

namespace SignalR.BusinessLayer.Profiles;

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
