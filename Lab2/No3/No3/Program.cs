using System;

namespace No3
{
    class Program
    {
        static void Main(string[] args)
        {

            int r;
            int c;
            int i, j;

                
                Console.WriteLine("Enter number of rows: ");
                Console.WriteLine("Enter number of columns: ");

                for (i = 1; i <= 5; i++)
                {
                    for (j = i; j < i + 8; j++)
                    {
                        Console.WriteLine("1 2 3 4 5", j);
                    }

                    Console.WriteLine("\n");
                }

            }
        }
}

