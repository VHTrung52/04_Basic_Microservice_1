﻿using Ordering.Domain.Abstractions;
using Ordering.Domain.ValueObjects;

namespace Ordering.Domain.Models;

public class OrderItem : Entity<Guid>
{
    internal OrderItem(Guid orderId, Guid productId, int quantity, decimal price)
    {
        OrderId = orderId;
        ProductId = productId;
        Quantity = quantity;
        Price = price;
    }
    
    public Guid OrderId { get; private set; } = default!;
    public Guid ProductId { get; private set; } = default!;
    public int Quantity { get; private set; }
    public decimal Price { get; private set; }
}