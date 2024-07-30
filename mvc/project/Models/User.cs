using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project.Models{
    public class User{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id{get;set;}

        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string? UserName{get;set;}

        [Required]
        [StringLength(20, MinimumLength = 8)]
        public string? Password{get;set;} 

        [Required]
        public bool Role{get;set;}


        public ICollection<Pruchase>? Pruchases{get;set;}
    }
}