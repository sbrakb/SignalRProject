using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalR.BusinessLayer.Abstracts;
using SignalR.BusinessLayer.Dtos.Requests.Discount;
using SignalR.BusinessLayer.Dtos.Responses.Discount;
using SignalR.DataAccessLayer.Abstracts;

namespace SignalR.BusinessLayer.Concretes;

public class DiscountManager : IDiscountService
{
    private readonly IDiscountDal _discountDal;
    private readonly IMapper _mapper;
    public DiscountManager(IDiscountDal discountDal, IMapper mapper)
    {
        _discountDal = discountDal;
        _mapper = mapper;
    }

    public async Task<CreatedDiscountResponse> AddAsync(CreateDiscountRequest createDiscountRequest)
    {
        Discount discount = _mapper.Map<Discount>(createDiscountRequest);
        await _discountDal.AddAsync(discount);
        CreatedDiscountResponse createdDiscountResponse = _mapper.Map<CreatedDiscountResponse>(discount);
        return createdDiscountResponse;
    }

    public async Task<DeletedDiscountResponse> DeleteAsync(DeleteDiscountRequest deleteDiscountRequest)
    {
        Discount discount = await _discountDal.GetAsync(deleteDiscountRequest.Id);
        await _discountDal.DeleteAsync(discount);
        DeletedDiscountResponse deletedDiscountResponse = _mapper.Map<DeletedDiscountResponse>(discount);
        return deletedDiscountResponse;
    }

    public async Task<GetDiscountResponse> GetAsync(GetDiscountRequest getDiscountRequest)
    {
        Discount discount = await _discountDal.GetAsync(getDiscountRequest.Id);
        GetDiscountResponse getDiscountResponse = _mapper.Map<GetDiscountResponse>(discount);
        return getDiscountResponse;
    }

    public async Task<List<GetDiscountResponse>> GetListAsync()
    {
        List<Discount> discounts = await _discountDal.GetListAsync();
        List<GetDiscountResponse> getDiscountResponses = _mapper.Map<List<GetDiscountResponse>>(discounts);
        return getDiscountResponses;
    }

    public async Task<UpdatedDiscountResponse> UpdateAsync(int id, UpdateDiscountRequest updateDiscountRequest)
    {
        Discount discount = await _discountDal.GetAsync(id);
        _mapper.Map(updateDiscountRequest, discount);
        await _discountDal.UpdateAsync(discount);
        UpdatedDiscountResponse updatedDiscountResponse = _mapper.Map<UpdatedDiscountResponse>(discount);
        return updatedDiscountResponse;
    }
}