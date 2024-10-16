﻿namespace SignalRWebUI.BusinessLayer.Dtos.Responses.Product;

public record GetProductResponse
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public bool Status { get; set; }
}


