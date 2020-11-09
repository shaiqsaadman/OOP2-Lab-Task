using System;


namespace lab6
{
    class Account
    {
        private string accName;

        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }
        private string acId;

        public string AcId
        {
            get { return acId; }
            set { acId = value; }
        }
        private int balance;

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public Account()
        {
            Console.WriteLine("Empty Student Constructor .");
        }
        public Account(string accName, string acId, int balance)
        {
            this.accName = accName;
            this.acId = acId;
            this.balance = balance;
        }
        public void Deposit(int amount)
        {
            if (amount > 0)
            { balance += amount; }
        }
        public void Withdraw(int amount)
        {
            if (amount > 0 && amount < balance)
            { balance -= amount; }
        }
        public void Transfer(int amount, Account receiver)
        {
            if (amount < balance)
            {
                this.balance -= amount;
                receiver.balance += amount;
            }
            else
                Console.WriteLine("Transection failed .");

        }



    }
}
