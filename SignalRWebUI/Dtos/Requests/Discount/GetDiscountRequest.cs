namespace SignalRWebUI.BusinessLayer.Dtos.Requests.Discount;

public record GetDiscountRequest
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Amount { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}
