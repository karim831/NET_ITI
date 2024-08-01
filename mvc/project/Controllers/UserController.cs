using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using project.Models;
using project.ViewModels;


namespace project.Contorllers{
    public class UserController : Controller{
        private StoreContext store = new StoreContext();
        private static User? userSession = null;

        public IActionResult Login(){
            return View();
        } 

        public IActionResult LoginConfirmed(UserView userView){
            if(ModelState.IsValid){
                var user = store.Users.FirstOrDefault((u) => (u.UserName == userView.UserName) && u.Role == false);
                if(user != null && user.Password == userView.Password){
                    userSession = new User(){
                        Id = user.Id,
                        UserName = user.UserName,
                        Password = user.Password,
                        Role = user.Role
                    };
                    return RedirectToAction("ProductPruchased");
                }
            }
            ModelState.AddModelError(string.Empty, "Username or password isn't correct");
            return View("Login",userView);
        }


        public IActionResult ProductPruchased(){
            if(userSession != null){
                List<ProductPruchased> products = store.Pruchases.Where(p => p.UserId == userSession.Id).Select(
                    p => new ProductPruchased(){
                        ProductName = p.Product.Name,
                        Price = p.Product.Price,
                        Date = p.Date,
                        Quantity = p.Quntity
                    }
                ).ToList();

                return View("ProductPruchased",
                    new UserProductPruchased(){
                        UserName = userSession.UserName,
                        ProductsPruchased = products
                    }
                );
            }
            return RedirectToAction("Login");
        }


        public IActionResult Logout(){
            return RedirectToAction("Login");
        }
    }
}