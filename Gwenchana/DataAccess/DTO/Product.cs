// using System.ComponentModel.DataAnnotations.Schema;

namespace Gwenchana.DataAccess.DTO
{
    public class Product
    {
        public int Product_Id { get; set; }
        public int? Supplier_Id { get; set; }
        public string productName { get; set; }
        public decimal price { get; set; }
        public int stockQuantity { get; set; }
        public string Manufacturer { get; set; }

        
        // Lưu số lượng sản phẩm KHÁCH HÀNG MUỐN MUA (không phải số lượng tồn kho)
        // [NotMapped]
        public int? quantity { get; set; }
    }
}
