using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer.DTOs
{
    public class UserOrderDTO
    {
        
        public int UserOrderID { get; set; }
        public int UserID { get; set; }
        public int OrderID { get; set; }
      
        public int Price { get; set; }
        public string Decision { get; set; }
    }
}
