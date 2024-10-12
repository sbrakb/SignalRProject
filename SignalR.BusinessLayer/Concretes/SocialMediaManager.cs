using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalRWebUI.BusinessLayer.Abstracts;
using SignalRWebUI.BusinessLayer.Dtos.Requests.SocialMedia;
using SignalRWebUI.BusinessLayer.Dtos.Responses.SocialMedia;
using SignalRWebUI.DataAccessLayer.Abstracts;

namespace SignalRWebUI.BusinessLayer.Concretes;

public class SocialMediaManager : ISocialMediaService
{
    private readonly ISocialMediaDal _socialMediaDal;
    private readonly IMapper _mapper;
    public SocialMediaManager(ISocialMediaDal socialMediaDal, IMapper mapper)
    {
        _socialMediaDal = socialMediaDal;
        _mapper = mapper;
    }

    public async Task<CreatedSocialMediaResponse> AddAsync(CreateSocialMediaRequest createSocialMediaRequest)
    {
        SocialMedia socialMedia = _mapper.Map<SocialMedia>(createSocialMediaRequest);
        await _socialMediaDal.AddAsync(socialMedia);
        CreatedSocialMediaResponse createdSocialMediaResponse = _mapper.Map<CreatedSocialMediaResponse>(socialMedia);
        return createdSocialMediaResponse;
    }

    public async Task<DeletedSocialMediaResponse> DeleteAsync(DeleteSocialMediaRequest deleteSocialMediaRequest)
    {
        SocialMedia socialMedia = await _socialMediaDal.GetAsync(deleteSocialMediaRequest.Id);
        await _socialMediaDal.DeleteAsync(socialMedia);
        DeletedSocialMediaResponse deletedSocialMediaResponse = _mapper.Map<DeletedSocialMediaResponse>(socialMedia);
        return deletedSocialMediaResponse;
    }

    public async Task<GetSocialMediaResponse> GetAsync(GetSocialMediaRequest getSocialMediaRequest)
    {
        SocialMedia socialMedia = await _socialMediaDal.GetAsync(getSocialMediaRequest.Id);
        GetSocialMediaResponse getSocialMediaResponse = _mapper.Map<GetSocialMediaResponse>(socialMedia);
        return getSocialMediaResponse;
    }

    public async Task<List<GetSocialMediaResponse>> GetListAsync()
    {
        List<SocialMedia> socialMedias = await _socialMediaDal.GetListAsync();
        List<GetSocialMediaResponse> getSocialMediaResponses = _mapper.Map<List<GetSocialMediaResponse>>(socialMedias);
        return getSocialMediaResponses;
    }

    public async Task<UpdatedSocialMediaResponse> UpdateAsync(int id, UpdateSocialMediaRequest updateSocialMediaRequest)
    {
        SocialMedia socialMedia = await _socialMediaDal.GetAsync(id);
        _mapper.Map(updateSocialMediaRequest, socialMedia);
        await _socialMediaDal.UpdateAsync(socialMedia);
        UpdatedSocialMediaResponse updatedSocialMediaResponse = _mapper.Map<UpdatedSocialMediaResponse>(socialMedia);
        return updatedSocialMediaResponse;
    }
}