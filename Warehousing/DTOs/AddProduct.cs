using BaseBackend.Entities;
using BaseBackend.Enums;
using System;

namespace Warehousing.DTOs
{
    public sealed class AddProduct
    {
        public string ProductName { get; set; }
        public ProductCategory Category { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Description { get; set; }
        public Warehouse Warehouse { get; set; }
        public MeasurementUnit Unit { get; set; }
    }
}
