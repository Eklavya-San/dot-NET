using HR;

public class ListOfEmp{
    public static void Main (string [] args){
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();
        var employees = new List <Employee>();
        employees.Add(new Employee(){
            Id=01,FirstName="Eklavya",Email="eklavyaghodake@gmail.com",
            ContactNumber="12312423534"
        });
        employees.Add(new Employee(){
            Id=02,FirstName="Isha",Email="Isha@gmail.com",
            ContactNumber="12312423534"
        });employees.Add(new Employee(){
            Id=03,FirstName="Neera",Email="neera@gmail.com",
            ContactNumber="12312423534"
        });employees.Add(new Employee(){
            Id=04,FirstName="vika",Email="vika@gmail.com",
            ContactNumber="12312423534"
        });


    app.MapGet("/",()=>employees);
    app.Run();
    }
}