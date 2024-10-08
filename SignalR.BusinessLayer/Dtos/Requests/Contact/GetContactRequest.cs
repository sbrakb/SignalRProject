﻿namespace SignalR.BusinessLayer.Dtos.Requests.Contact;

public record GetContactRequest
{
    public int Id { get; set; }
    public string Location { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public string FooterDescription { get; set; }
}
