using System;
using System.ComponentModel.DataAnnotations;

namespace EShop.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
		[Display(Name = "Price (lei)")]
        public decimal Price { get; set; }
		public string Unit { get; set; }
		[Display(Name = "Expiry Date")]
        [DataType(DataType.Date)]
		public DateTime ExpiryDate { get; set; }
    }
}