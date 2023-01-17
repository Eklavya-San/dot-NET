using webapp.Models;
using +
namespace DAL;

public class DBManager {
    public List <Employee> GetAll() {
        using (var context = new CollectionsContext()){
            var employees = from employee in context.Employees select employee;
            return employees.ToList<Employee>();
        }
    }
}