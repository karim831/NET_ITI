using Microsoft.AspNetCore.Mvc;
using lab2.Models;



namespace lab2.Controllers;

public class CollegeController : Controller{

    private CollegeContext college = new CollegeContext();

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

    public IActionResult UpdateStudentConfirmed(Student student){
        if (ModelState.IsValid){
            var s = college.Students.FirstOrDefault((s) => s.Id == student.Id);
            s.Name = student.Name;
            s.DepartmentId = student.DepartmentId;
            college.Students.Update(s);
            college.SaveChanges();
            return RedirectToAction("StudentTable");
        }
        return View("UpdateStudent",student);
    }


    public IActionResult AddStudent(){
        return View();
    }

    public IActionResult AddStudentConfirmed(Student student){
        if (ModelState.IsValid){
            college.Students.Add(student);
            college.SaveChanges();
            return RedirectToAction("StudentTable");
        }
        else{
            return View("AddStudent",student);
        }
    }
}