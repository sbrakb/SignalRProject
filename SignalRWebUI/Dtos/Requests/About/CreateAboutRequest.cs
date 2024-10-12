namespace SignalRWebUI.BusinessLayer.Dtos.Requests.About;

public record CreateAboutRequest
{
    public string ImageUrl { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}
