using student;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using aboutus.Models;

namespace aboutus.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    
   
    List<Student> studentList = new List <Student>();
    
        

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
     public IActionResult StudentList()

    {
        studentList.Add(new Student{
            Id=01,
            FirstName="Eklavya",
            LastName="Ghodake",
            Email="eklavyaghodake@gmail.com",
            Password="thisissparta",
            ContactNumber="9090909090"
        });
        studentList.Add(new Student{
            Id=01,
            FirstName="Eklavya",
            LastName="Ghodake",
            Email="eklavyaghodake@gmail.com",
            Password="thisissparta",
            ContactNumber="9090909090"
        });studentList.Add(new Student{
            Id=01,
            FirstName="Eklavya",
            LastName="Ghodake",
            Email="eklavyaghodake@gmail.com",
            Password="thisissparta",
            ContactNumber="9090909090"
        });
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult AdmissionForm(){
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
