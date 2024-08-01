using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace project.ViewModels{
    public class ProductPruchased{
        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string ProductName{get;set;} = null!;
    
        [Required]
        [Range(1.0, 10000.00)]
        public decimal Price{get;set;}
    
        [Required]
        public DateTime Date{get;set;}
    
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        public int Quantity{get;set;}
    }

}