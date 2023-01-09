using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SomnathTapri.Models;
namespace SomnathTapri.Controllers;

public class UserController : Controller
{
    static List <Member> CollegeChiPor = new List<Member> ();


    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Register()
    {
        return View();
    }
    public IActionResult Login()
    {
        return View();
  }
   public IActionResult Registered()
    {
        return View();
    }
     public IActionResult NewMember(string fullname,string email,string password )
    {
        Member m1 = new Member(fullname,email,password);
        CollegeChiPor.Add(m1);
        return Redirect("./Registered");
    }
    public IActionResult PoranchiList (){
        ViewData["PoranchiList"]=CollegeChiPor;
        return View ();
    }
}
