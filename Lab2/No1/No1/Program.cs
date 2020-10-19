using System;

namespace No1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n=1000;
            Console.WriteLine("Numbers from 1 to n are: " );

            for(int i = 1; i <= n; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i + "");
                }
            }
        }
    }
}
