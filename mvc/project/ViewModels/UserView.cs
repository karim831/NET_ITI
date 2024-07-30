using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace project.ViewModels{
    public class UserView{
        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string? UserName{get;set;}

        [Required]
        [StringLength(20, MinimumLength = 8)]
        [PasswordValidation]
        public string? Password{get;set;} 
    }
}