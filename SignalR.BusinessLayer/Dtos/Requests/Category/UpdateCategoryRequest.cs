namespace SignalR.BusinessLayer.Dtos.Requests.Category;

public record UpdateCategoryRequest
{
    public string Name { get; set; }
    public bool Status { get; set; }
}
