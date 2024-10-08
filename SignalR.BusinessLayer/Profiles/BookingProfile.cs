using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalR.BusinessLayer.Dtos.Requests.Booking;
using SignalR.BusinessLayer.Dtos.Responses.Booking;

namespace SignalR.BusinessLayer.Profiles;

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
