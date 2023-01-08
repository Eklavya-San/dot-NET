using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Members.Models;
namespace Members.Controllers;


public class UserController : Controller
{
    private readonly ILogger<HomeController> _logger;

    static List <Member> catalog = new List<Member>();
   
            public IActionResult Form()
    {
        return View();
    }
   public IActionResult NewMember(string FirstName,string LastName,string inlineRadioOptions,string Email,string Password,string PhoneNumber,string Duration)
    { 
        Member newMember = new Member(FirstName,LastName,inlineRadioOptions,Email,Password,PhoneNumber,Duration);
        catalog.Add(newMember);
        return Redirect("./Successful");
    }

    public IActionResult MemberList()
    {
        ViewData ["Catalog"]=catalog;
        return View();
    }
    public IActionResult Successful()
    {
        return View();
    }
   
   
    
}
