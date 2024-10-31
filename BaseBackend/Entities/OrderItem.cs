using BaseBackend.Entities.Interfaces;

namespace BaseBackend.Entities
{
    public class OrderItem:IBaseEntity
    {
        int nextid = 0;
        public int Id { get; set; } //شناسه جزئیات سفارش
        public Product Product { get; set; }  //محصول انتخاب شدده
        public decimal Quantity { get; set; } //تعداد محصول در سفارش
        public MeasurementUnit Unit { get; set; } //واحد اندازه گیری

        public decimal TotalProductPrice //محاسبه قیمت محصول = تعداد * قیمت واحد
        {
            get
            {
                if (Product != null)
                {
                    return Quantity * Product.Price;
                }
                else
                {
                    
                    return 0; 
                }
            }
        }

        public OrderItem()
        {
            Id = nextid;
            nextid++;
        }
        public OrderItem(Product product,decimal quantity,MeasurementUnit unit):this()
        {
            Product = product;
            Quantity=quantity;
            Unit = unit;
        }
    }
}
