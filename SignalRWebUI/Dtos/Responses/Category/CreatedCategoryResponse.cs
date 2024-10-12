namespace SignalRWebUI.Dtos.Responses.Category;

public record CreatedCategoryResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Status { get; set; }
}
