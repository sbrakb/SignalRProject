using SignalR.BusinessLayer.Dtos.Requests.Discount;
using SignalR.BusinessLayer.Dtos.Responses.Discount;

namespace SignalR.BusinessLayer.Abstracts;

public interface IDiscountService
{
    Task<List<GetDiscountResponse>> GetListAsync();
    Task<GetDiscountResponse> GetAsync(GetDiscountRequest getDiscountRequest);
    Task<CreatedDiscountResponse> AddAsync(CreateDiscountRequest createDiscountRequest);
    Task<UpdatedDiscountResponse> UpdateAsync(int id, UpdateDiscountRequest updateDiscountRequest);
    Task<DeletedDiscountResponse> DeleteAsync(DeleteDiscountRequest deleteDiscountRequest);
}


