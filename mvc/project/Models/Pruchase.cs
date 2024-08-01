using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project.Models{
    [PrimaryKey(nameof(UserId), nameof(ProductId))]
    public class Pruchase{
        [Required]
        public int UserId{get;set;}
        [Required]
        public int ProductId{get;set;}

        [Required]
        public DateTime Date{get;set;}

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        public int Quntity{get;set;}

        [ForeignKey("UserId")]
        public User User{get;set;} = null!; 

        [ForeignKey("ProductId")]
        public Product Product{get;set;} = null!;
    }
}