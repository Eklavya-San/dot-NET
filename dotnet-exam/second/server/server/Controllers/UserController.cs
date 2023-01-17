using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using DAL;
using BOL;
namespace UserController;

[ApiController]
[Route ("api/[controller]")]

public class UserController : ControllerBase{
     private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }
    
    [HttpGet]
    [EnableCors()]
    public IEnumerable<User> GetAllUsers()
    {
        List<User> users = UsersDataAccess.GetAllUsers();
        return users;
    }

    [HttpPost]
    [EnableCors()]

    public IActionResult InsertNewUser (User user){
        UsersDataAccess.NewUser(user);
        return Ok(new{message = "User created"});
    }

[Route("{id}")]
[HttpDelete]
[EnableCors()]
    public IActionResult DeleteOneUser(int id){
        UsersDataAccess.DeleteId(id);
        return Ok(new {message="user deleted"});
    }

} 