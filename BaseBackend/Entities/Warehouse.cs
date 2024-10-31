using BaseBackend.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BaseBackend.Entities
{
    public class Warehouse: IBaseEntity
    {
        // خصوصیات انبار
        private static int nextId = 1; //متغیر static برای تولید Id بعدی
        public int Id { get; set; }          // شناسه انبار
        public string Name { get; set; }   //نام انبار 
        public string Location { get; set; }          // مکان انبار

        public List<Product> products; //لیست محصولات
        // سازنده
        public Warehouse()
        {
            Id = nextId;
            nextId++;
        }
        public Warehouse(string name):this()
        {
            Name = name;
        }
        public Warehouse(string name,string location):this(name)
        {
            Location = location;
            products = new List<Product>();// لیستی از محصولات
        }

        // افزودن محصول به انبار
        public void AddProductToWarehouse(Product product)
        {
            if (products.Any(p => p.Name == product.Name))
            {
                Console.WriteLine("محصول در لیست موجود است.");
            }
            else
            {
                products.Add(product);
            }
      
        }

        // کم کردن موجودی محصول از انبار
        public void RemoveProductFromWarehouse(Product product, int quantity)
        {
            if (products.Any(p => p.Name == product.Name))
            {
                if (product.Quantity > quantity)
                    product.Quantity -= quantity;
                else
                {
                    Console.WriteLine("موجودی کم است.");
                }
            }
            else
                Console.WriteLine("محصول موجود نیست");
        }

        // جستجوی محصول بر اساس شناسه
        public Product FindProductById(int productId)
        {
            foreach (var item in products)
            {
                if (item.Id== productId)
                {
                    return item; // محصول مورد نظر پیدا شد
                }
            }
            return null; // اگر محصول یافت نشد
        }

       // چک کردن موجود بودن یک کالا
        public bool IsValidQuantity(int productId)
        {
            var product = FindProductById(productId);
            return product!=null? true : false;
        }
    }

}
