using SignalRWebUI.BusinessLayer.Dtos.Requests.Feature;
using SignalRWebUI.BusinessLayer.Dtos.Responses.Feature;

namespace SignalRWebUI.BusinessLayer.Abstracts;

public interface IFeatureService
{
    Task<List<GetFeatureResponse>> GetListAsync();
    Task<GetFeatureResponse> GetAsync(GetFeatureRequest getFeatureRequest);
    Task<CreatedFeatureResponse> AddAsync(CreateFeatureRequest createFeatureRequest);
    Task<UpdatedFeatureResponse> UpdateAsync(int id, UpdateFeatureRequest updateFeatureRequest);
    Task<DeletedFeatureResponse> DeleteAsync(DeleteFeatureRequest deleteFeatureRequest);
}


