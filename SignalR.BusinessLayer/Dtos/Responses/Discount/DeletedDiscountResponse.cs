namespace SignalR.BusinessLayer.Dtos.Responses.Discount;

public class DeletedDiscountResponse
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Amount { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}