#nullable disable
namespace BaseBackend.Entities
{
    public class Inventory
    {
        public int InventoryId { get; set; } // شناسه موجودی
        public int WarehouseId { get; set; } //شناسه انبار
        public int ProductId { get; set; } //شناسه کالا
        public int Quantity { get; set; } //مقدار موجودی کالا

    }

}
