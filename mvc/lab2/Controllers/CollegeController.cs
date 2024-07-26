using Microsoft.AspNetCore.Mvc;
using lab2.Models;


namespace lab2.Controllers;

public class CollegeController : Controller{

    CollegeContext college = new CollegeContext();

    public IActionResult StudentTable(){
        return View("StudentTable",college.Students.ToList());
    }

    public IActionResult DeleteStudent(int id){
        var student = college.Students.ToList().FirstOrDefault(s => s.Id == id); 
        if(student == null){
            return NotFound();
        }
        return View("DeleteStudent",student);
    }

    public async Task<IActionResult> DeleteStudentConfirmed(int id){
        var student = college.Students.FirstOrDefault(s => s.Id == id); 
        if(student != null){
            college.Students.Remove(student);
            await college.SaveChangesAsync();
        }
        return StudentTable();
    }

    public IActionResult UpdateStudent(int id){
        var student = college.Students.FirstOrDefault((s) => s.Id == id);
        if(student != null){
            return View("UpdateStudent",student);
        }
        return NotFound();
    }

    public IActionResult UpdateStudentConfirmed(){
        if(Request != null){
            var student = college.Students.FirstOrDefault((s) => s.Id == int.Parse(Request.Form["Id"]));
            
            if(student != null){
                student.Name = Request.Form["Name"];
                student.DepartmentId = int.Parse(Request.Form["DepartmentId"]);
                college.Students.Update(student);
                college.SaveChanges();
            }
        }
        return RedirectToAction("StudentTable");
    }


    public IActionResult AddStudent(){
        return View();
    }


    public IActionResult AddStudentConfirmed(){
        if(Request != null){
            var student = new Student(){
                Name = Request.Form["Name"],
                DepartmentId = int.Parse(Request.Form["DepartmentId"])
            };
            college.Students.Add(student);
            college.SaveChanges();
        }
        return RedirectToAction("StudentTable");
    }

}