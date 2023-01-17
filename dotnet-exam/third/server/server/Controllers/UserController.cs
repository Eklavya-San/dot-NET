using Microsoft.AspNetCore.Mvc;
using DAL;
using BOL;
using Microsoft.AspNetCore.Cors;
namespace server.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [EnableCors()]
    public IEnumerable <User> GetUsers(){
        List<User> users = UsersDataAccess.GetUsers();
        return users;
    }

    [HttpPost]
    [EnableCors()]
    public ActionResult InserNew (User user){
        UsersDataAccess.saveUser(user);
        return Ok(new {message = "User Created"});
    }
   
}
