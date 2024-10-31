using BaseBackend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Warehousing.DTOs
{
    public sealed class AddOrderItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }          //  شناسه کالا
        public Product Product { get; set; }  //محصول انتخاب شدده
        public int Quantity { get; set; } //تعداد محصول در سفارش
        public MeasurementUnit Unit { get; set; } //واحد اندازه گیری
    }
}
