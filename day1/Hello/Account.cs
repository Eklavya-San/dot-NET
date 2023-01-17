namespace Banking;

public double Balance {get;set;}
public int  AccountNo { get;set;}
public static int counter=1;
public Account (double amount ){
    this.Balance=amount;
    this.AccountNo=counter++;
}

public Account (){
    this.Balance= 1000;
    this.AccountNo= counter++;
}

public void Withdraw (float amount ){
    if(amount == 0 ){
        throw new Exception ("Amount can not be zero");
    } else if(this.Balance<amount){
        throw new Exception ("Sorry you don't have enough balance");
    }
    this.balance -= amount;
}

public void Deposit(float amount){
   this.balance+=amount;
}
public void Deposit (float amount ){
    this.balance += amount ;

}


