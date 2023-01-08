using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Members.Models;
namespace Members.Controllers;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


public class UserController : Controller
{
    private readonly ILogger<HomeController> _logger;
    //Deserialize so we will get old list if there is one 
    static string fileName ="/home/monster/dotNet/lab/dot-NET/MessMembership/Members/members.json";
    static string jsonString = System.IO.File.ReadAllText(fileName);

    static List <Member> catalog = JsonSerializer.Deserialize<List<Member>>(jsonString);

    // static List <Member> catalog = new List<Member>();
   
            public IActionResult Form()
    {
        return View();
    }
   public IActionResult NewMember(string FirstName,string LastName,string inlineRadioOptions,string Email,string Password,string PhoneNumber,string Duration)
    { 
        Member newMember = new Member(FirstName,LastName,inlineRadioOptions,Email,Password,PhoneNumber,Duration);
        catalog.Add(newMember);
          var options=new JsonSerializerOptions {IncludeFields=true};
          var memberJson=JsonSerializer.Serialize<List<Member>>(catalog,options);
          System.IO.File.WriteAllText(fileName,memberJson);
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
    public IActionResult Login(){
        return View();
    }
    [Route("/User/Authentication")]
    public IActionResult Authentication (string email,string pass){
        Boolean flag =false;
        
        foreach(Member m in catalog){
            if(email?.Equals(m.Email)==true&&pass?.Equals(m.Password)==true){
                flag=true;
            }
        }
        if(flag){
                return Redirect("./MemberPage");

        }else{

        return Redirect("./LoginFailed");
        }
    }
    public IActionResult LoginFailed(){
        return View();
    }
     public IActionResult MemberPage(){
        return View();
    }
     public IActionResult ForgotPass(){
        return View();
    }
    
   
    
}
