using SignalR.BusinessLayer.Dtos.Requests.SocialMedia;
using SignalR.BusinessLayer.Dtos.Responses.SocialMedia;

namespace SignalR.BusinessLayer.Abstracts;

public interface ISocialMediaService
{
    Task<List<GetSocialMediaResponse>> GetListAsync();
    Task<GetSocialMediaResponse> GetAsync(GetSocialMediaRequest getSocialMediaRequest);
    Task<CreatedSocialMediaResponse> AddAsync(CreateSocialMediaRequest createSocialMediaRequest);
    Task<UpdatedSocialMediaResponse> UpdateAsync(int id, UpdateSocialMediaRequest updateSocialMediaRequest);
    Task<DeletedSocialMediaResponse> DeleteAsync(DeleteSocialMediaRequest deleteSocialMediaRequest);
}


