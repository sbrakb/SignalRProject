using SignalR.BusinessLayer.Dtos.Requests.Feature;
using SignalR.BusinessLayer.Dtos.Responses.Feature;

namespace SignalR.BusinessLayer.Abstracts;

public interface IFeatureService
{
    Task<List<GetFeatureResponse>> GetListAsync();
    Task<GetFeatureResponse> GetAsync(GetFeatureRequest getFeatureRequest);
    Task<CreatedFeatureResponse> AddAsync(CreateFeatureRequest createFeatureRequest);
    Task<UpdatedFeatureResponse> UpdateAsync(int id, UpdateFeatureRequest updateFeatureRequest);
    Task<DeletedFeatureResponse> DeleteAsync(DeleteFeatureRequest deleteFeatureRequest);
}


