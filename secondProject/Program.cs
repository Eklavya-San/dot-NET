using System;
// using Banking;



bool exit = false;
List<Banking> accountList = new List<Banking>();

while (!exit)
{
    Console.WriteLine("Welcome to swiss bank");
    Console.WriteLine("1.Create an account\n2.Show Account details \n3.Banking Services\n0.Exit");
    Console.WriteLine("Choose option");
    string choice =Console.ReadLine(); 
    switch (Convert.ToInt32(choice))
    {
        case 1:
            Console.WriteLine("Enter your name and first deposit amount");
            string name = Console.ReadLine();
            double amount = Convert.ToDouble(Console.ReadLine());
            accountList.Add(new Banking(name, amount));

            break;
        case 2:
            foreach (Banking details in accountList)
            {
                Console.WriteLine(details);
            }
            break;
        case 3:
            
            ValidateLogin(accountNo,name);
            break;
        case 0:
            exit = true;
            Console.WriteLine("Program Exitted");
            break;
    }
}