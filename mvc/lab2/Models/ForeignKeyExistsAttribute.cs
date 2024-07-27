using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using lab2.Models;

public class ForeignKeyExistsAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        CollegeContext college = new CollegeContext();
        if(college.Departments.FirstOrDefault(d => d.Id == (int)value) != null)
            return ValidationResult.Success;
        return new ValidationResult("There is no id match");
    }
}