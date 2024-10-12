using SignalRWebUI.BusinessLayer.Dtos.Requests.About;
using SignalRWebUI.BusinessLayer.Dtos.Responses.About;

namespace SignalRWebUI.BusinessLayer.Abstracts;

public interface IAboutService 
{
    Task<CreatedAboutResponse> AddAsync(CreateAboutRequest createAboutRequest);
    Task<UpdatedAboutResponse> UpdateAsync(int id, UpdateAboutRequest updateAboutRequest);
    Task<DeletedAboutResponse> DeleteAsync(DeleteAboutRequest deleteAboutRequest); 
    Task<GetAboutResponse> GetAsync(GetAboutRequest getAboutRequest);
    Task<List<GetAboutResponse>> GetListAsync();
}


