namespace Goverment;
public delegate void TaxOperation (double amount);
public class TaxSlab
{
    public void DeductIncomeTax(double amount){
        Console.WriteLine("voilaa... 45% tax will be reducted from your account");
    }
    public void DeductServiceTax(double amount){
        Console.WriteLine("voilaa... 15% tax will be reducted from your account ");
    }
    public void DeductProfessionalTax(double amount){
        Console.WriteLine("voilla.. 30% tax will be reducted from your account");
    }
}
