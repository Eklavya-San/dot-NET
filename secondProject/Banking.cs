using System;
public class Banking {
    private int accountNo;
    private string name;
    private double balance ;
    private static int counter = 1;


public Banking (string name , double balance ){
    this.name = name;
    this.balance=balance;
    this.accountNo=counter++;    

}

public string Name 
{
    get{return name;}
    set{this.name = value;}
}

public double Balance {
    get {return balance;}
    set {this.balance=value;}
}

public void display (){
    Console.WriteLine("Account NO : "+ this.accountNo);
    Console.WriteLine("Name : "+ this.name);
    Console.WriteLine("Balance : "+ this.balance);

}


public override string  ToString(){
    return "Account NO : "+ this.accountNo+"Name : "+ this.name + "Balance : " + this.balance;
}

public bool withdraw(double amount){
    if(this.balance>amount){
        this.balance=balance-amount;
        Console.WriteLine("Amount debited {0}\nfrom account no:{1} \n remaining balance is :{2}",amount,this.accountNo,this.balance);
        return true;
    }
    else{
        Console.WriteLine("You Don't have sufficient balance \n your balance is :"+this.balance);
        return false;
    }
}

public bool deposit(double amount){
        this.balance=balance+amount;
        Console.WriteLine("Amount Credited {0}\nfrom account no:{1} \n remaining balance is :{2}",amount,this.accountNo,this.balance);
        return true;
    
    }
}