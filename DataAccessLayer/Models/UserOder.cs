using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class UserOder
    {
        [Key]
        public int UserOrderID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public int OrderID { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string Decision { get; set; }

    }
}
