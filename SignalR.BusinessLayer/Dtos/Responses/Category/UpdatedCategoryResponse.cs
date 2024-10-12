namespace SignalRWebUI.BusinessLayer.Dtos.Responses.Category;

public record UpdatedCategoryResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Status { get; set; }
}
