using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalR.BusinessLayer.Abstracts;
using SignalR.BusinessLayer.Dtos.Requests.About;
using SignalR.BusinessLayer.Dtos.Responses.About;
using SignalR.DataAccessLayer.Abstracts;


namespace SignalR.BusinessLayer.Concretes;

public class AboutManager : IAboutService
{
    private readonly IAboutDal _aboutDal;
    private readonly IMapper _mapper;
    public AboutManager(IAboutDal aboutDal, IMapper mapper)
    {
        _aboutDal = aboutDal;
        _mapper = mapper;
    }

    public async Task<CreatedAboutResponse> AddAsync(CreateAboutRequest createAboutRequest)
    {
        About about = _mapper.Map<About>(createAboutRequest);
        await _aboutDal.AddAsync(about);
        CreatedAboutResponse createdAboutResponse = _mapper.Map<CreatedAboutResponse>(about);
        return createdAboutResponse;
    }

    public async Task<DeletedAboutResponse> DeleteAsync(DeleteAboutRequest deleteAboutRequest)
    {
        About about = await _aboutDal.GetAsync(deleteAboutRequest.Id);
        await _aboutDal.DeleteAsync(about);
        DeletedAboutResponse deletedAboutResponse = _mapper.Map<DeletedAboutResponse>(about);
        return deletedAboutResponse;
    }

    public async Task<GetAboutResponse> GetAsync(GetAboutRequest getAboutRequest)
    {
        About about = await _aboutDal.GetAsync(getAboutRequest.Id);
        GetAboutResponse getAboutResponse = _mapper.Map<GetAboutResponse>(about);
        return getAboutResponse;
    }

    public async Task<List<GetAboutResponse>> GetListAsync()
    {
        List<About> abouts = await _aboutDal.GetListAsync();
        List<GetAboutResponse> getAboutResponses = _mapper.Map<List<GetAboutResponse>>(abouts);
        return getAboutResponses;
    }

    public async Task<UpdatedAboutResponse> UpdateAsync(int id, UpdateAboutRequest updateAboutRequest)
    {
        About about = await _aboutDal.GetAsync(id);
        _mapper.Map(updateAboutRequest, about);
        await _aboutDal.UpdateAsync(about);
        UpdatedAboutResponse updatedAboutResponse = _mapper.Map<UpdatedAboutResponse>(about);
        return updatedAboutResponse;
    }
}
