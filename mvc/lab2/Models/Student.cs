using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab2.Models;
public class Student{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id{get;set;}

    [Required]
    [StringLength(20,MinimumLength = 5)]
    public string Name{get;set;}


    public int DepartmentId{get;set;}

    [ForeignKey("DepartmentId")]
    public virtual Department Department{get;set;}
}