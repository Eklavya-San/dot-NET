using Banks;
using Goverment;
TaxSlab myGov = new TaxSlab();

TaxOperation itOperation = new TaxOperation(myGov.DeductIncomeTax);
TaxOperation otherOperation = new TaxOperation (myGov.DeductProfessionalTax);
TaxOperation entertainmentOperation = new TaxOperation (myGov.DeductServiceTax);

TaxOperation? generalOperation = null;

generalOperation=itOperation;
generalOperation+=otherOperation;
generalOperation+=entertainmentOperation;


Console.WriteLine("Enter first deposit amount");
double amount= double.Parse(Console.ReadLine());
Account account1= new Account(amount);

account1.overBalance+= generalOperation;

Console.WriteLine("Enter amount to be deposited");
amount = double.Parse(Console.ReadLine());
account1.deposit(amount);

Console.WriteLine("Before Tax Processing :");
Console.WriteLine(account1);

account1.ProcessTax();
Console.WriteLine("After Tax Processing :");

Console.WriteLine(account1);
