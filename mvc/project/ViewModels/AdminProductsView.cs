using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using project.Models;

namespace project.ViewModels{
    public class AdminProductsView{
        public int Id{get;set;}

        public string UserName{get;set;} = null!;
        
        public IEnumerable<Product> Products{get;set;} = null!;
    }
}