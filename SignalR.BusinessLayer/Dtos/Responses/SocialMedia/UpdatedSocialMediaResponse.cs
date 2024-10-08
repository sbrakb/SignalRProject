namespace SignalR.BusinessLayer.Dtos.Responses.SocialMedia;

public record UpdatedSocialMediaResponse
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
}

