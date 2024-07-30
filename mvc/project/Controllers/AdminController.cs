using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using project.Models;
using project.ViewModels;

namespace project.Contorllers{
    public class AdminController : Controller{
        private StoreContext store = new StoreContext();

        public IActionResult Login(){
            return View();
        }

        public IActionResult LoginConfirmed(UserView userView){
            if(ModelState.IsValid){
                var admin = store.Users.FirstOrDefault((u) => (u.UserName == userView.UserName) && u.Role == true);
                if(admin != null && admin.Password == userView.Password)
                    return RedirectToAction("Index","Home");
            }
            ModelState.AddModelError(string.Empty, "Username or password isn't correct");
            return View("Login",userView);
        }
    }
}


// foreach (var state in ModelState){
//                     var key = state.Key;
//                     var errors = state.Value.Errors;
//                     foreach (var error in errors){
//                         Console.WriteLine($"Key: {key}, Error: {error.ErrorMessage}");
//                     }
//                 }