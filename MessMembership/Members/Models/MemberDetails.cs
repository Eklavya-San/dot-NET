namespace Members.Models;


public class Member {
    public string FirstName {
        get; set;
    }
    public string LastName {
        get; set;
    }
    public string Gender {
        get; set;
    }
    public string Email {
        get; set;
    }
     public string Password {
        get; set;
    }
    public string PhoneNumber {
        get; set;
    }
     public string Duration {
        get; set;
    }

    public Member(string FirstName,string LastName,string Gender,string Email,string Password,string PhoneNumber,string Duration) {
        this.FirstName=FirstName;
        this.LastName=LastName;
        this.Duration=Duration;
        this.Email=Email;
        this.Password=Password;
        this.Gender=Gender;
        this.PhoneNumber=PhoneNumber;
    }
    public override string ToString()
    {
        return "First Name "+this.FirstName;
    }
    
}// public override string ToString()
    // {
    //     return "First Name "+this.FirstName;
    // }
    