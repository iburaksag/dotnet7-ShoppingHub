﻿using ShoppingHub.Domain.Entities.Common;

namespace ShoppingHub.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public double UnitPrice { get; set; }
        public string Category { get; set; }
        public string? Description { get; set; }

        public ICollection<BasketDetail>? BasketDetails { get; set; }
    }
}

