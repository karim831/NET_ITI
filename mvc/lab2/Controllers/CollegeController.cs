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
}