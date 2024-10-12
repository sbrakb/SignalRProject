using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalRWebUI.BusinessLayer.Abstracts;
using SignalRWebUI.BusinessLayer.Dtos.Requests.Feature;
using SignalRWebUI.BusinessLayer.Dtos.Responses.Feature;
using SignalRWebUI.DataAccessLayer.Abstracts;

namespace SignalRWebUI.BusinessLayer.Concretes;

public class FeatureManager : IFeatureService
{
    private readonly IFeatureDal _featureDal;
    private readonly IMapper _mapper;
    public FeatureManager(IFeatureDal featureDal, IMapper mapper)
    {
        _featureDal = featureDal;
        _mapper = mapper;
    }

    public async Task<CreatedFeatureResponse> AddAsync(CreateFeatureRequest createFeatureRequest)
    {
        Feature feature = _mapper.Map<Feature>(createFeatureRequest);
        await _featureDal.AddAsync(feature);
        CreatedFeatureResponse createdFeatureResponse = _mapper.Map<CreatedFeatureResponse>(feature);
        return createdFeatureResponse;
    }

    public async Task<DeletedFeatureResponse> DeleteAsync(DeleteFeatureRequest deleteFeatureRequest)
    {
        Feature feature = await _featureDal.GetAsync(deleteFeatureRequest.Id);
        await _featureDal.DeleteAsync(feature);
        DeletedFeatureResponse deletedFeatureResponse = _mapper.Map<DeletedFeatureResponse>(feature);
        return deletedFeatureResponse;
    }

    public async Task<GetFeatureResponse> GetAsync(GetFeatureRequest getFeatureRequest)
    {
        Feature feature = await _featureDal.GetAsync(getFeatureRequest.Id);
        GetFeatureResponse getFeatureResponse = _mapper.Map<GetFeatureResponse>(feature);
        return getFeatureResponse;
    }

    public async Task<List<GetFeatureResponse>> GetListAsync()
    {
        List<Feature> features = await _featureDal.GetListAsync();
        List<GetFeatureResponse> getFeatureResponses = _mapper.Map<List<GetFeatureResponse>>(features);
        return getFeatureResponses;
    }

    public async Task<UpdatedFeatureResponse> UpdateAsync(int id, UpdateFeatureRequest updateFeatureRequest)
    {
        Feature feature = await _featureDal.GetAsync(id);
        _mapper.Map(updateFeatureRequest, feature);
        await _featureDal.UpdateAsync(feature);
        UpdatedFeatureResponse updatedDiscountResponse = _mapper.Map<UpdatedFeatureResponse>(feature);
        return updatedDiscountResponse;
    }
}