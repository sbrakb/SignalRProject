namespace SignalR.BusinessLayer.Dtos.Requests.Discount;

public record CreateDiscountRequest
{
    public string Title { get; set; }
    public string Amount { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}
