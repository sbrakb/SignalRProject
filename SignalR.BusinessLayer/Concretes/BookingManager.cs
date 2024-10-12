using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalRWebUI.BusinessLayer.Abstracts;
using SignalRWebUI.BusinessLayer.Dtos.Requests.Booking;
using SignalRWebUI.BusinessLayer.Dtos.Responses.Booking;
using SignalRWebUI.DataAccessLayer.Abstracts;

namespace SignalRWebUI.BusinessLayer.Concretes;

public class BookingManager : IBookingService
{
    private readonly IBookingDal _bookingDal;
    private readonly IMapper _mapper;
    public BookingManager(IBookingDal bookingDal, IMapper mapper)
    {
        _bookingDal = bookingDal;
        _mapper = mapper;
    }

    public async Task<CreatedBookingResponse> AddAsync(CreateBookingRequest createBookingRequest)
    {
        Booking booking = _mapper.Map<Booking>(createBookingRequest);
        await _bookingDal.AddAsync(booking);
        CreatedBookingResponse createdBookingResponse = _mapper.Map<CreatedBookingResponse>(booking);
        return createdBookingResponse;

    }

    public async Task<DeletedBookingResponse> DeleteAsync(DeleteBookingRequest deleteBookingRequest)
    {
        Booking booking = await _bookingDal.GetAsync(deleteBookingRequest.Id);
        await _bookingDal.DeleteAsync(booking);
        DeletedBookingResponse deletedBookingResponse = _mapper.Map<DeletedBookingResponse>(booking);
        return deletedBookingResponse;
    }

    public async Task<GetBookingResponse> GetAsync(GetBookingRequest getBookingRequest)
    {
        Booking booking = await _bookingDal.GetAsync(getBookingRequest.Id);
        GetBookingResponse getBookingResponse = _mapper.Map<GetBookingResponse>(booking);
        return getBookingResponse;
    }

    public async Task<List<GetBookingResponse>> GetListAsync()
    {
        List<Booking> bookings = await _bookingDal.GetListAsync();
        List<GetBookingResponse> getBookingResponses = _mapper.Map<List<GetBookingResponse>>(bookings);
        return getBookingResponses;
    }

    public async Task<UpdatedBookingResponse> UpdateAsync(int id, UpdateBookingRequest updateBookingRequest)
    {
        Booking booking = await _bookingDal.GetAsync(id);
        _mapper.Map(updateBookingRequest, booking);
        await _bookingDal.UpdateAsync(booking);
        UpdatedBookingResponse updatedBookingResponse = _mapper.Map<UpdatedBookingResponse>(booking);
        return updatedBookingResponse;

    }
}