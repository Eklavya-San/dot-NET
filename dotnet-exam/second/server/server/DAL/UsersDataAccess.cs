namespace DAL;
using BOL;
using System.Data;
using MySql.Data.MySqlClient;

public class UsersDataAccess{
    public static string conString = @"server=localhost;port=3306;user=root; password=root123; database=nova";

    public static List<User> GetAllUsers(){
        List<User>allNotes = new List<User>();
        MySqlConnection con = new MySqlConnection (conString);

        try
        {
            con.Open();
            string query = "select * from users";
            DataSet ds = new DataSet();
            MySqlCommand command= new MySqlCommand(query,con);
            MySqlDataAdapter da = new MySqlDataAdapter (command);
            da.Fill(ds);

            DataTable dt = ds.Tables[0];
            DataRowCollection rows =dt.Rows;

            foreach(DataRow row in rows){
                User user = new User {
                    userid = int.Parse(row["userid"].ToString()),
                    username = row["username"].ToString(),
                    course = row["course"].ToString(),
                    fees=int.Parse(row["fees"].ToString())
                };
                allNotes.Add(user);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            
        }
        finally{
            con.Close();
        }
        return allNotes;
    }

    public static void NewUser (User user){
        MySqlConnection con = new MySqlConnection (conString);
        try
        {
            con.Open();

            string query = $"insert into users (username,course,fees) values('{user.username}','{user.course}','{user.fees}')";
            MySqlCommand command = new MySqlCommand(query,con);
            command.ExecuteNonQuery();
            con.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            
        }
        finally{
            con.Close();
        }
    }

    public static void DeleteId (int id ){
        MySqlConnection con = new MySqlConnection (conString);

        try
        {
            con.Open();
            string query = "delete from users where userid ="+id;
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
    }

   
}