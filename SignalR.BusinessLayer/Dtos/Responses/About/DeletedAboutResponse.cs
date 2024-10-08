namespace SignalR.BusinessLayer.Dtos.Responses.About;

public record DeletedAboutResponse
{
    public int Id { get; set; }
    public string ImageUrl { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}
