namespace DAL;
using BOL;
using System.Data;
using MySql.Data.MySqlClient;

public class UsersDataAccess {
    public static string conString = $"server=localhost; port=3306; user=root; password=root123;database=studentdata;";
    public static List<User> GetUsers(){

        List <User> allUsers = new List<User>();
        MySqlConnection con = new MySqlConnection(conString);

        try
        {
         string query = "select * from user";
         DataSet ds = new DataSet(); 
         MySqlCommand cmd = new MySqlCommand (query,con);  
         MySqlDataAdapter da = new MySqlDataAdapter(cmd);
         da.Fill(ds);

         DataTable dt = ds.Tables[0];
         DataRowCollection rows = dt.Rows;
         foreach(DataRow row in rows){
            User user = new User {
                rollNo=int.Parse(
                    row["rollno"].ToString()),
                    name=row["name"].ToString(),
                    course=row["course"].ToString()
                
            };
            allUsers.Add(user);
         }
        }
        catch (Exception e)
        {
            
            Console.WriteLine(e.Message);
        }
        finally{
            con.Close();
        }
        return allUsers;
    }

    public static void saveUser(User user){
        MySqlConnection con = new MySqlConnection(conString);
        try{
            con.Open();
            string query= $"insert into user(rollno,name,course) values({user.rollNo},'{user.name}','{user.course}')";

            MySqlCommand command = new MySqlCommand(query,con);
            command.ExecuteNonQuery();
            con.Close();
        
    }catch(Exception e){
        Console.WriteLine(e.Message);
    }
    finally{
        con.Close();
    }
}
}