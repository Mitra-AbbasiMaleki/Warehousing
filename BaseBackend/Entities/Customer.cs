#nullable disable
using BaseBackend.Entities.Interfaces;
using BaseBackend.Enums;
using System;
using System.Collections.Generic;
namespace BaseBackend.Entities
{
    public class Customer:Person, IBaseEntity
    {
        // ویژگی‌های مشتری

        public DateTime RegistrationDate { get; set; }  // تاریخ ثبت‌ نام مشتری
        private List<Order> Orders { get; set; }  // سوابق سفارش

        // سازنده کلاس
        public Customer()
        {
            RegistrationDate = DateTime.Now; // ثبت تاریخ فعلی به عنوان تاریخ ثبت‌نام
            Orders = new List<Order>();  // ایجاد لیست خالی برای سوابق سفارش
        }
        public Customer(UserRole role, string firstName, string lastName, string nationalCode):base(role, firstName, lastName, nationalCode) //فراخوانی سازنده کلاس پایه
        {
            
        }
        public Customer(UserRole role,string firstName, string lastName, string nationalCode, string phoneNumber, Address address,Address otherAddress=null): base(role, firstName, lastName, nationalCode, phoneNumber, address,otherAddress)  //فراخوانی سازنده کلاس پایه
        {
            RegistrationDate = DateTime.Now; // ثبت تاریخ فعلی به عنوان تاریخ ثبت‌نام
            Orders = new List<Order>();  // ایجاد لیست خالی برای سوابق سفارش
        }

        // افزودن سفارش به سوابق مشتری
        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
    }


}
