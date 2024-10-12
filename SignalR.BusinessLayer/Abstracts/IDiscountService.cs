using SignalRWebUI.BusinessLayer.Dtos.Requests.Discount;
using SignalRWebUI.BusinessLayer.Dtos.Responses.Discount;

namespace SignalRWebUI.BusinessLayer.Abstracts;

public interface IDiscountService
{
    Task<List<GetDiscountResponse>> GetListAsync();
    Task<GetDiscountResponse> GetAsync(GetDiscountRequest getDiscountRequest);
    Task<CreatedDiscountResponse> AddAsync(CreateDiscountRequest createDiscountRequest);
    Task<UpdatedDiscountResponse> UpdateAsync(int id, UpdateDiscountRequest updateDiscountRequest);
    Task<DeletedDiscountResponse> DeleteAsync(DeleteDiscountRequest deleteDiscountRequest);
}


