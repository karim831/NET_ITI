using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab2.Models;

public class Department{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id{get; set;}

    [Required]
    [StringLength(20,MinimumLength = 5)]
    public string Name{get; set;}


    public virtual ICollection<Student> Students{get; set;}
}