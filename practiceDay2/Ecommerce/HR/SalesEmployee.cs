namespace HR;

public float Traget{
    get;
    set;
}
public float SalesDone{
    get;
    set;
}
public float Insentive{
    get;
    set;
}

public SalesEmployee ( int id,string firstName,string LastName,string email,string contactNumber,string location,DateTime bDate,float da, float hra, float bsal, float target,float salesDone):base (
    id,firstName,LastName,email,contactNumber,location,bDate,da,hra,bsal
){
    this.Traget=target;
    this.SalesDone=salesDone;
    this.Insentive=0;
}

public override void DoWork(){
    if(SalesDone>=Target){
        this.Incentive=5000;
    }else{
        this.Incentive=0;
    }
}

public override float ComputePay(){
    float salary = base.ComputePay() + Incentive;
    return salary;
}

public override String ToString(){
    return base.ToString() + "Incentive :"+ Incentive + "Target: "+Target;
}
