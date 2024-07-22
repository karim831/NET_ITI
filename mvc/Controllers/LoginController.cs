using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc.Models;

namespace mvc.Controllers;


public class LoginController{

    [HttpGet]
    public IActionResult Login(){
        return new ViewResult();
    }

    [HttpPost]
    public IActionResult Login(string username,string password){
        if(username == "karim" && password == "password")
            return new JsonResult(new{Username = username, password = password});
        return new ViewResult();
    }

}