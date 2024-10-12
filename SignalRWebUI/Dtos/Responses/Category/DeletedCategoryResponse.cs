namespace SignalRWebUI.Dtos.Responses.Category;

public record DeletedCategoryResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Status { get; set; }
}
