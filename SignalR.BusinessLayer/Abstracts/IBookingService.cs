using SignalRWebUI.BusinessLayer.Dtos.Requests.Booking;
using SignalRWebUI.BusinessLayer.Dtos.Responses.Booking;

namespace SignalRWebUI.BusinessLayer.Abstracts;

public interface IBookingService 
{
    Task<CreatedBookingResponse> AddAsync(CreateBookingRequest createBookingRequest);
    Task<UpdatedBookingResponse> UpdateAsync(int id, UpdateBookingRequest updateBookingRequest);
    Task<DeletedBookingResponse> DeleteAsync(DeleteBookingRequest deleteBookingRequest);
    Task<GetBookingResponse> GetAsync(GetBookingRequest getBookingRequest);
    Task<List<GetBookingResponse>> GetListAsync();
}


