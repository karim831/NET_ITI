using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace project.ViewModels{
    public class AdminView{
        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string UserName{get;set;} = null!;

        [Required]
        [StringLength(20, MinimumLength = 8)]
        [PasswordValidation]
        public string Password{get;set;} = null!; 
    }
}