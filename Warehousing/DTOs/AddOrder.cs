using BaseBackend.Entities;
using BaseBackend.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Warehousing.DTOs
{
    public sealed class AddOrder
    {
        public Customer Customer { get; set; }   // مرجع به مشتری که سفارش را داده است
        public List<OrderItem> OrderItems { get; set; } // لیست آیتم‌های موجود در سفارش
        public Address Address { get; set; }  // آدرس مشتری
    }
}
