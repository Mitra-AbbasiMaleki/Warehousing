#nullable disable
using BaseBackend.Entities.Interfaces;
using BaseBackend.Enums;
using System.Collections.Generic;
namespace BaseBackend.Entities
{
    public class Supplier:Person, IBaseEntity
    {
        public string CompanyName { get; set; } //نام شرکت
        public List<Product> Products { get; set; }// لیست کالاهایی که تامین میکند
        //کلاس سازنده تامین کننده
        public Supplier(UserRole role, string companyName,string firstName,string lastName,string nationalCode,string phoneNumber, Address address)
            :base(role,firstName,  lastName, nationalCode,phoneNumber,address)     //فراخوانی سازنده کلاس پایه
        {
            CompanyName = companyName;
            Products = new List<Product>();
        }
        // افزودن کالا به لیست تأمین‌شده‌ها
        public void AddSuppliedProduct(Product product)
        {
            Products.Add(product);
        }
    }

}
