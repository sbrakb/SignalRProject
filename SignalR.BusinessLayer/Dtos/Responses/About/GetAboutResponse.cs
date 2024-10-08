namespace SignalR.BusinessLayer.Dtos.Responses.About;

public record GetAboutResponse
{
    public int Id { get; set; }
    public string ImageUrl { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}
