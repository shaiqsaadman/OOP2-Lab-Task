using System;


namespace FinalLabOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Savings("Shaiq", 1000);
            a1.ShowInfo();
            a1.Deposit(100);
            a1.Withdraw(300);
            a1.ShowInfo();
            Console.WriteLine();
          
            Account a2 = new Fixed("Shaiq", 1000);
            a2.ShowInfo();
            a2.Deposit(100);
            a2.Withdraw(300);
            a2.ShowInfo();
            
        }
    }
}
