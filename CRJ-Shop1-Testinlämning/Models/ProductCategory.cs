﻿namespace CRJ_Shop.Models
{
    public class ProductCategory
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }

}