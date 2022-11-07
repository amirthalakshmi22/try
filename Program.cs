namespace BankInfo{
public class Program
{
    public string accno;
   
    public string password;
   
   public double balance;
   public string lname;
   public string fname;
   public double BalanceAmt
   {
       get{
       return balance;
       }
   }
   double interest=12;
public double Interestrate
{
    get{
        return interest;
    }
    set{
        double percent=(interest*10)/100;
        if((interest-percent)<=value &&  (interest+percent)>=value)
        {
            interest=value;
        }
        else{
            Console.WriteLine("Interest is not given propoerly");
        }
    }
}



public void Deposit()
{
    Console.WriteLine("Enter amount to be deposited");
    double damount=0;
    damount = Convert.ToDouble(Console.ReadLine());
    if(damount<0)
    {
        Console.WriteLine("Enter value greater than 0");
    }
    else
    {
    damount=damount+balance;
    Console.WriteLine("The amount remains in account is"+damount);
    balance=damount;
        Console.WriteLine("The amount remains in account is"+balance);

    }

}
public void Withdraw()
{
    Console.WriteLine("enter amount to withdraw");
    double wamount;
    wamount=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter your password");
    string p1;
    p1=Console.ReadLine();
   
    if(wamount<0 || balance<0 )
    {
       Console.WriteLine("Enter value greater than 0"); 
    }
     else if(p1==password)
    { 
    wamount=balance-wamount;
    balance=wamount;
    Console.WriteLine("The amount remains in account is"+balance);
    }
    else{
        Console.WriteLine("Print nothing");
    }

}
public void Display()
{
    Console.WriteLine("Account Number:"+accno);
    Console.WriteLine("First Name:"+fname);
    Console.WriteLine("Last Name:"+lname);
    Console.WriteLine("Balance:"+balance);
}

public void CheckName()
{
    lname="Singh";
    fname="Amit";
    Console.WriteLine("Enter your fname");
       string  firstname=Console.ReadLine();
          Console.WriteLine("Enter your lname");
        string lastname=Console.ReadLine();
    if(lname==lastname)
    {
       
        fname=firstname;
        Console.WriteLine(firstname+" "+lastname);
    }
    else
    {
        Console.WriteLine("Cannot be changed");
    }
}
}
}