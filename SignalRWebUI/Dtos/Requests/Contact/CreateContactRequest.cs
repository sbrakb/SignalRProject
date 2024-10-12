namespace SignalRWebUI.BusinessLayer.Dtos.Requests.Contact;

public record CreateContactRequest
{
    public string Location { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public string FooterDescription { get; set; }
}
