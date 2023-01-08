namespace HR;
public class Employee
{
    public int Id{
        get;
        set;
    }
    public string FirstName{
        get;
        set;
    }
    public string LastName{
        get;
        set;
    }
    public string ContactNumber{
        get;
        set;
    }
    public string Location {
        get;
        set;
    }
    public DateTime BirthDate{
        get;
        set;
    }
    public float DA{
        get;
        set;
    }
    public float HRA{
        get;
        set;
    }
    public float BasicSalary{
        get;
        set;
    }

    public Employee():this(12,"Eklavya","Ghodake","eklavyaghodake@gmail.com","7721901494","pune",new DateTime(1995,10,09),4000,40000,200000){

    }
    public Employee (
        int id,
        string firstName,
        string LastName,
        string email,
        string contactNumber,
        string location,
        DateTime bdate,
        float da,
        float hra,
        float bsal
    ){
        this.Id=id;
        this.FirstName=firstName;
        this.LastName=LastName;
        this.Email=email;
        this.Location=location;
        this.ContactNumber=contactNumber;
        this.BasicSalary= bdate;
        this.HRA= hra;
        this.BasicSalary =bsal;
        this.DA=da;
    }
    public abstract void DoWork();
    //idk why is this here

    public virtual float ComputePay() {
        float pay = (DA * 25)+ BasicSalary + HRA ;
        return pay;
    }

    public override string ToString()
    {
        return string.Format("{0} \n,{1} \n,{2} \n,{3} \n,{4} \n,{5} \n ",Id,FirstName,LastName,Email,ContactNumber,Location);
    }
















}
