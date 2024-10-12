namespace SignalRWebUI.BusinessLayer.Dtos.Responses.Contact;

public record CreatedContactResponse
{
    public int Id { get; set; }
    public string Location { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public string FooterDescription { get; set; }
}
