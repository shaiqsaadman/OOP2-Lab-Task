using System;


namespace FinalLabOne
{
    class Savings:Account
    {
        
        
        public Savings(String accName,string accId,double balance):base(accName,accId,balance)
        {
            this.limitOfMonthlyTransaction = 5;
        }

        public override void Withdraw(int amount)
        {
            if (amount <= (Balance - 500))
            {
                Balance -= amount;
            }
            else
                Console.WriteLine("Withdraw failed.");
        }

       public override void ShowInfo()
        {
            
            Console.WriteLine("Account ID : " + AccId);
            Console.WriteLine("Balance : " + Balance);

        }
    }
}
