using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project.Models{
    public class Product{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id{get;set;}

        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string Name{get;set;} = null!;

        [Required]
        [Range(1.0, 10000.00)]
        public decimal Price{get;set;}

        [Required]
        public int Stock{get;set;}
        

        public IEnumerable<Pruchase> Pruchases{get;set;} = null!;

    }
}