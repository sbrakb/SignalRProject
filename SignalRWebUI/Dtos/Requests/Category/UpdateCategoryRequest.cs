namespace SignalRWebUI.Dtos.Requests.Category;

public record UpdateCategoryRequest
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Status { get; set; }
}
