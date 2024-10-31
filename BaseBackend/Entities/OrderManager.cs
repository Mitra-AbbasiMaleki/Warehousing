using BaseBackend.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BaseBackend.Entities
{
    public class OrderManager : IBaseEntity,IOrder
    {
        int nextid = 0;
        public int Id { get; set; }
        public Customer Customer { get; set; }     // نام مشتری 
        public List<OrderItem> OrderItems { get; set ; }   //لیست محصولات موجود در سفارش
        public OrderManager()
        {
            Id = nextid;
            nextid++;
            OrderItems = new List<OrderItem>();
        }
        //ایجاد سفارش جدید
        public Order CreateOrder(Customer customer, List<OrderItem> ordeItems)
        {
            Order newOrder = new Order(customer, orderItems:ordeItems);
            newOrder.OrderItems = ordeItems;
            customer.AddOrder(newOrder);
            return newOrder;
        }
        public bool AddOrderItem(OrderItem newItem)
        {
            if (IsProductDuplicate(newItem.Product))
                return false;
            else
            {
                OrderItems.Add(newItem);
                return true;
            }
        }

        public void RemoveOrderItem(Product product)
        {
            var itemToRemove = OrderItems.FirstOrDefault(item => item.Product.Id == product.Id);
            if (itemToRemove != null)
            {
                OrderItems.Remove(itemToRemove);
                Console.WriteLine("کالا از سفارش حذف شد.");
            }
            else
            {
                Console.WriteLine("کالایی با این مشخصات یافت نشد.");
            }
        }

        public void UpdateOrderItem(Product product, int newQuantity)
        {
            var itemToUpdate = OrderItems.FirstOrDefault(item => item.Product.Id == product.Id);
            if (itemToUpdate != null)
            {
                itemToUpdate.Quantity = newQuantity;
                Console.WriteLine("تعداد کالا به‌روز شد.");
            }
            else
            {
                Console.WriteLine("کالایی با این مشخصات یافت نشد.");
            }
        }

        public decimal GetOrderTotal()
        {
            return OrderItems.Sum(item => item.Quantity * item.Product.Price);
        }

        public bool IsProductDuplicate(Product product)
        {
            return OrderItems.Any(item => item.Product.Id == product.Id);
        }
    }
}
