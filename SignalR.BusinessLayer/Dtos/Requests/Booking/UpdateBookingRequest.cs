namespace SignalR.BusinessLayer.Dtos.Requests.Booking;

public record UpdateBookingRequest
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public int PersonCount { get; set; }
    public DateTime Date { get; set; }
}
