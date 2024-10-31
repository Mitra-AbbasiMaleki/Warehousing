#nullable disable
using BaseBackend.Entities.Interfaces;
using BaseBackend.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BaseBackend.Entities
{
    public class Order:IBaseEntity
    {
        private static int nextId = 1;                      // برای تولید Id
        public int Id { get; set; }                         //  شناسه سفارش
        public OrderStatus Status { get; set; }             // وضعیت سفارش
        public DateTime OrderDate { get; set; }             //تاریخ ثبت سفارش
        public Customer CustomerName { get; set; }          // مرجع به مشتری که سفارش را داده است
        public List<OrderItem> OrderItems { get; set; }          // لیست آیتم‌های موجود در سفارش
        public Address Address { get; set; }                // آدرس مشتری
        public decimal TotalAmount                          // مبلغ کل سفارش
        { 
            get
            {
                return OrderItems.Sum(item => item.TotalProductPrice);
            }
        }
        // سازنده
        public Order()
        {
            Id = nextId;
            nextId++;
            OrderDate = DateTime.Now;
        }
        public Order(Customer customerName, List<OrderItem> orderItems):this()
        {
            CustomerName = customerName;
            OrderItems=orderItems;
        }
    }
}
