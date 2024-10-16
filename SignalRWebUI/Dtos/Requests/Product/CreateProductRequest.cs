﻿namespace SignalRWebUI.BusinessLayer.Dtos.Requests.Product;

public record CreateProductRequest
{
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public bool Status { get; set; }
}

