namespace SignalR.BusinessLayer.Dtos.Requests.About;

public record UpdateAboutRequest
{
    public string ImageUrl { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}