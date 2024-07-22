using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace efcode_first.models;

public class User{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id{get;set;}

    [Required]
    [StringLength(10)]
    public string Fname{get;set;} = "";

    [Required]
    [StringLength(10)]
    public string Lname{get;set;} = "";

    [Required]
    [Range(20, 50, ErrorMessage = "Price must be between 0.01 and 10000.00")]
    public int Age{get;set;}

    [Required]
    [AllowedValues("Male", "Female", ErrorMessage = "Gender must be either 'Male' or 'Female'.")]
    public string Gender{get;set;} = "";

    public virtual List<Order> Orders{get;set;} = new List<Order>();
}