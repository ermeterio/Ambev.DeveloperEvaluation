﻿using Ambev.DeveloperEvaluation.Domain.Entities.Product;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Product.CreateUpdateProduct;

public class CreateUpdateProductRequest
{
    public required string Name { get; set; }
    public decimal Price { get; set; }
    public Guid CategoryId { get; set; }
    public ProductImage? Image { get; set; }
    public string Description { get; set; } = string.Empty;
    public int ActualStock { get; set; }
    public Guid CompanyId { get; set; }
}