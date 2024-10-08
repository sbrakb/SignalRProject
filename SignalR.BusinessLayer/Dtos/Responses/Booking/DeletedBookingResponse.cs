﻿namespace SignalR.BusinessLayer.Dtos.Responses.Booking;

public record DeletedBookingResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public int PersonCount { get; set; }
    public DateTime Date { get; set; }
}


