namespace What.Models;

public class student{
    public int RollNo{
        get;set;
    }
    public  string UserName{
        get;set;
    }
    public string Password{
        get;set;
    }
    public string Name{
        get;set;
    }
    public string Location{
        get;set;
    }
    public string Email{
        get;set;
    }

    public student (int RollNo,string UserName, string Password,string Name,string Email,string Location) {
        this.RollNo=RollNo;
        this.UserName=UserName;
        this.Password=Password;
        this.Name=Name;
        this.Email=Email;
        this.Location=Location;
    }

}