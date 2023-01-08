using Membership;
using HR;

Console.Writeline("Eklavya Store");
Console.Writeline("=======================================");

Console.Writeline("Enter Your Email ID");
string email = Console.ReadLine();

Console.Writeline("Enter Your Password");
string Password=Console.ReadLine();

if(AuthManager.Validate(email,Password)){
    Console.Writeline("Welcome to Transflower Store");
    Employee emp = SalesManager();
    emp.DoWork();
    Console.Writeline(emp);
    float salary =emp.ComputePay();
    Console.Writeline("Salary ="+salary);
}
else{
    Console.Writeline("Invalid User");
}

Console.Writeline("Thank You for visiting Transflower");