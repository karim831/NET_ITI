using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using project.Models;

namespace project.ViewModels{
    public class UpdateProductView{
        [Required]
        public int Id{get;set;}

        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string? Name{get;set;}

        [Required]
        [Range(1.0, 10000.00)]
        public decimal Price{get;set;}

        [Required]
        public int Stock{get;set;}
    }
}