using JaysData.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaysData.DTO
{
    public class CreateOrderDTO
    {
        
     
        [Required]
        public OrderType OrderType { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Quantity { get; set; }

        [Required]
        public string CustomerId { get; set; }
      
       
    }
}
