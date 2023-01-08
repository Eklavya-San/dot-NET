using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using What.Models;
namespace What.Controllers;
public class AuthController : Controller{
    private readonly ILogger<HomeController> _logger;
    static List  <student> studentList = new List<student>();

    public IActionResult Index() {
        return View();
    }


    public IActionResult StdObj(int rollNo,string userName,string password, string name,string location ,string email) {

        student s1 = new student(rollNo,userName,password,  name,location ,email);
        studentList.Add(s1);
        

        return Redirect("./Collect" );   
    }
    public IActionResult Collect(){
        ViewData["studentList"]=studentList;
        return View();
    }
}