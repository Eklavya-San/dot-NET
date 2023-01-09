namespace SomnathTapri.Models;

public class Member {
    public string FullName{
        get;set;
    }
    public string email {
        get;set;

    }
    public string password{
        get; set;
    }
    public Member(string fname,string email,string password){
        this.email=email;
        this.FullName=fname;
        this.password=password;
    }
}