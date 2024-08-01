using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace project.ViewModels{
    public class UserProductPruchased{
        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string UserName{get;set;} = null!;

        public IEnumerable<ProductPruchased> ProductsPruchased{get;set;} = null!;
    }
}