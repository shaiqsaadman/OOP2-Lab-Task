using System;


namespace FinalLAbOne
{
    abstract class Account
    {
        
        
        public Account(string accName, string acId, double balance)
        {
            AccountHolderName = accName;
            AccId= acId;
            Balance = balance;
        }
        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("Deposite amount : " + amount);
            }
        }
        abstract public void Withdraw(int amount);
        
        public void Transfer(int amount, Account receiver)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                receiver.Balance += amount;
            }
            else
                Console.WriteLine("Transection failed .");

        }
        abstract public void ShowInfo();

    }
}
