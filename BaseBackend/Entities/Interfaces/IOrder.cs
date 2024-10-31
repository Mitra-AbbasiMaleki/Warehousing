using System.Collections.Generic;


namespace BaseBackend.Entities.Interfaces
{
    public interface IOrder
    {
        public Customer Customer { get; set; }
        public List<OrderItem> OrderItems { get; set; }   //لیست سفارشات مشتری
        public Order CreateOrder(Customer customer, List<OrderItem> orderItems);  // متد برای ایجاد سفارش
 
    }
}
