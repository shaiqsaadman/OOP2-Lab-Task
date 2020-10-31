using System;

namespace Account
{
    
    
        class Program
        {
            private string accName { get; set; }
            private string acid;
            private int balance;
            static void Main(string[] args)
            {
                Program p = new Program();
                p.accName ="hello";
                p.acid = 10;
                p.balance = 10;


            int m = p.accName;
            int n = p.acid;
            int o = p.balance;

            Console.WriteLine(m);
                Console.WriteLine(n);
            Console.WriteLine(o);

            Console.ReadLine();
            }
        }
    
}
