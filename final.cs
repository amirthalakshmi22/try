

using System;
using BankInfo;

class final
{
    public static void Main()
    {
        Program b =new Program();
        string firstname,lastname;
         Console.WriteLine("Enter your account number");
         b.accno=Console.ReadLine();
          
          Console.WriteLine("Enter your password");
         b.password=Console.ReadLine();
         b.Interestrate=14;
        Console.WriteLine(b.Interestrate);
       
        int op;
          
         do{
             Console.WriteLine("Enter your option");
             Console.WriteLine("1.Deposit 2.Withdraw 3. Display 4.NameCheck");
            op=Convert.ToInt32(Console.ReadLine());
              
         switch(op)
         {
             case 1: b.Deposit();
             break;
             case 2: b.Withdraw();
             break;
             case 3:b.Display();
             break;
             case 4:b.CheckName();
             break;
             
         }
         }while(op!=0);
        
        

    }
}

