using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace efcode_first.models;


public class Item{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id{get;set;}

    [Required]
    [StringLength(10)]
    public string Name{get;set;}

    public virtual List<Order> Orders{get;set;} = new List<Order>();
}