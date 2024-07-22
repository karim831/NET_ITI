using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace efcode_first.models;


public class Order{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id{get;set;}

    [Required]
    [StringLength(100)]
    public string Name{get;set;} = "";

    public int UserId{get;set;}

    public virtual List<Item> Items{get;set;} = new List<Item>();

    [ForeignKey("UserId")]
    public virtual User User{get;set;} = new User();

}