using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalR.BusinessLayer.Abstracts;
using SignalR.BusinessLayer.Dtos.Requests.Testimoinal;
using SignalR.BusinessLayer.Dtos.Responses.Testimoinal;
using SignalR.DataAccessLayer.Abstracts;

namespace SignalR.BusinessLayer.Concretes;

public class TestimoinalManager : ITestimoinalService
{
    private readonly ITestimoinalDal _testimoinalDal;
    private readonly IMapper _mapper;
    public TestimoinalManager(ITestimoinalDal testimoinalDal, IMapper mapper)
    {
        _testimoinalDal = testimoinalDal;
        _mapper = mapper;
    }

    public async Task<CreatedTestimoinalResponse> AddAsync(CreateTestimoinalRequest createTestimoinalRequest)
    {
        Testimoinal testimoinal = _mapper.Map<Testimoinal>(createTestimoinalRequest);
        await _testimoinalDal.AddAsync(testimoinal);
        CreatedTestimoinalResponse createdTestimoinalResponse = _mapper.Map<CreatedTestimoinalResponse>(testimoinal);
        return createdTestimoinalResponse;
    }

    public async Task<DeletedTestimoinalResponse> DeleteAsync(DeleteTestimoinalRequest deleteTestimoinalRequest)
    {
        Testimoinal testimoinal = await _testimoinalDal.GetAsync(deleteTestimoinalRequest.Id);
        await _testimoinalDal.DeleteAsync(testimoinal);
        DeletedTestimoinalResponse deletedTestimoinalResponse = _mapper.Map<DeletedTestimoinalResponse>(testimoinal);
        return deletedTestimoinalResponse;
    }

    public async Task<GetTestimoinalResponse> GetAsync(GetTestimoinalRequest getTestimoinalRequest)
    {
        Testimoinal testimoinal = await _testimoinalDal.GetAsync(getTestimoinalRequest.Id);
        GetTestimoinalResponse getTestimoinalResponse = _mapper.Map<GetTestimoinalResponse>(testimoinal);
        return getTestimoinalResponse;
    }

    public async Task<List<GetTestimoinalResponse>> GetListAsync()
    {
        List<Testimoinal> testimoinals = await _testimoinalDal.GetListAsync();
        List<GetTestimoinalResponse> getTestimoinalResponses = _mapper.Map<List<GetTestimoinalResponse>>(testimoinals);
        return getTestimoinalResponses;
    }

    public async Task<UpdatedTestimoinalResponse> UpdateAsync(int id, UpdateTestimoinalRequest updateTestimoinalRequest)
    {
        Testimoinal testimoinal = await _testimoinalDal.GetAsync(id);
        _mapper.Map(updateTestimoinalRequest, testimoinal);
        await _testimoinalDal.UpdateAsync(testimoinal);
        UpdatedTestimoinalResponse updatedTestimoinalResponse = _mapper.Map<UpdatedTestimoinalResponse>(testimoinal);
        return updatedTestimoinalResponse;
    }
}