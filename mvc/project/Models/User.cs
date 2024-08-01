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
        public string UserName{get;set;} = null!;

        [Required]
        [StringLength(20, MinimumLength = 8)]
        public string Password{get;set;} = null!; 

        [Required]
        public bool Role{get;set;}


        public IEnumerable<Pruchase> Pruchases{get;set;} = null!;
    }
}