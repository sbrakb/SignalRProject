using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalRWebUI.BusinessLayer.Dtos.Requests.Booking;
using SignalRWebUI.BusinessLayer.Dtos.Responses.Booking;

namespace SignalRWebUI.BusinessLayer.Profiles;

public class BookingProfile : Profile
{
    public BookingProfile()
    {
        CreateMap<CreateBookingRequest, Booking>().ReverseMap();
        CreateMap<Booking, CreatedBookingResponse>().ReverseMap();

        CreateMap<Booking, DeletedBookingResponse>().ReverseMap();

        CreateMap<Booking, GetBookingResponse>().ReverseMap();

        CreateMap<UpdateBookingRequest, Booking>().ReverseMap();
        CreateMap<Booking, UpdatedBookingResponse>().ReverseMap();
    }
}
