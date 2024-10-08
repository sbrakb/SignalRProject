namespace SignalR.BusinessLayer.Dtos.Requests.Category;

public record CreateCategoryRequest
{
    public string Name { get; set; }
    public bool Status { get; set; }
}
