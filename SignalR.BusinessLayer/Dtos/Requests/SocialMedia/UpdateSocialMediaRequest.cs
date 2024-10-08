namespace SignalR.BusinessLayer.Dtos.Requests.SocialMedia;

public record UpdateSocialMediaRequest
{
    public string Title { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
}
