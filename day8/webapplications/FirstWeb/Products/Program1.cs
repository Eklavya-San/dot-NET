// using HR;
// public class BasicOfWeb {
//     public static void Main(string [] args ){
//         var builder = WebApplication.CreateBuilder(args);
//         var app = builder.Build();
//         var emp = new Employee () {
//             Id=29, FirstName="Shubhangi", Email="Tambade",
//             ContactNumber="12431341"
//         };
//         app.MapGet("/",()=>"hello World");
//         app.MapGet("/home",()=>emp);
//         app.Run();
//     }
// }