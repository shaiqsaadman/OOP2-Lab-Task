using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Lab2
{
    class ScientificCalculator : IScientificCalculatorInterface
    {
        public ScientificCalculator()
        {
            Console.WriteLine("Scientific calculator.");
        }
        
        public double SquareRoot(double x)
        {
            Console.WriteLine("Square Root : "+ Math.Sqrt(x));
            return Math.Sqrt(x);
        }

        public int XtoY(int x, int y)
        {
            Console.WriteLine("X To Y : " + Convert.ToInt32(Math.Pow(x, y)));
            return Convert.ToInt32(Math.Pow(x, y));
        }

       


    }
}
