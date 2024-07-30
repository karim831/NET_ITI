using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using project.Models;
using project.ViewModels;

namespace project.Contorllers{
    public class AdminController : Controller{
        private StoreContext store = new StoreContext();
        private static User? adminSession;


        public IActionResult Login(){
            return View();
        }

        public IActionResult LoginConfirmed(AdminView userView){
            if(ModelState.IsValid){
                var admin = store.Users.FirstOrDefault((u) => (u.UserName == userView.UserName) && u.Role == true);
                if(admin != null && admin.Password == userView.Password){
                    adminSession = new User(){
                        Id = admin.Id,
                        UserName = admin.UserName,
                        Password = admin.Password,
                        Role = admin.Role
                    };
                    return RedirectToAction("Products");
                }
            }
            ModelState.AddModelError(string.Empty, "Username or password isn't correct");
            return View("Login",userView);
        }

        public IActionResult Products(){
            if(adminSession != null){
                AdminProductsView adminProductsView = new AdminProductsView(){
                    Id = adminSession.Id,
                    UserName = adminSession.UserName,
                    Products = store.Products.ToList()
                };
                return View("Products",adminProductsView);
            }
            return RedirectToAction("Login");
        }


        public IActionResult AddProduct(){
            return View();
        }

        public IActionResult AddProductConfirmed(AddProductView product){
            if(ModelState.IsValid){
                store.Products.Add(
                    new Product(){
                        Id = store.Products.Max(p => p.Id)+1,
                        Name = product.Name,
                        Price = product.Price,
                        Stock = product.Stock
                    }
                );
                store.SaveChanges();
                return RedirectToAction("Products");
            }
            return View("AddProduct",product);
        }

        public IActionResult UpdateProduct(int id){
            var product = store.Products.First(p => p.Id == id);            
            return View("UpdateProduct",
                new UpdateProductView(){
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Stock = product.Stock
                }
            );
        }

        public IActionResult UpdateProductConfirmed(UpdateProductView productView){
            if(ModelState.IsValid){
                var product = store.Products.First(p => p.Id == productView.Id);
                product.Name = productView.Name;
                product.Price = productView.Price;
                product.Stock = productView.Stock;
                store.Products.Update(product);
                store.SaveChanges();
                return RedirectToAction("Products");
            }
            return View("UpdateProduct",productView);
        }

        public IActionResult DeleteProduct(int id){
            var product = store.Products.First(p => p.Id == id);
            return View("DeleteProduct",
                new DeleteProductView(){
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Stock = product.Stock
                }
            );
        }

        public IActionResult DeleteProductConfirmed(DeleteProductView productView){
            if(ModelState.IsValid){
                var product = store.Products.First(p => p.Id == productView.Id);
                store.Products.Remove(product);
                store.SaveChanges();
            }
            return RedirectToAction("Products");
        }

        public IActionResult Logout(){
            adminSession = null;
            return RedirectToAction("Login");
        }
    }
}