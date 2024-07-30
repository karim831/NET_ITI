using project.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace project.ViewModels{
    public class PasswordValidationAttribute : ValidationAttribute{
        protected override ValidationResult? IsValid(Object? value,ValidationContext validationContext){
            string? password = value?.ToString()?.ToUpper();
            if(password != null){
                if(PasswordIsValid(password))
                    return ValidationResult.Success;
                return  new ValidationResult("Password should be {A : Z}, {a : z} or {0 to 9}");
            }
            return new ValidationResult("Password Field is Required!");
        }

        public bool PasswordIsValid(string password){
            for(int i=0;i<password.Length;i++){
                if((password[i]<'A' || password[i]>'Z') && (password[i]<'0' || password[i]>'9')){
                    return false;
                }
            }
            return true;
        }
    }
}