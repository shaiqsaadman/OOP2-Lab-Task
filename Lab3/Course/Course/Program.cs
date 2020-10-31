using System;

namespace Course
{
    
    
        class Program
        {
            private string courseName { get; set; }
            private string courseCode;
            private int courseCredit;

            static void Main(string[] args)
            {
                Program p = new Program();
                p.courseName = "abc";
                p.courseCode = 10;
                p.courseCredit = 10;

                int m = p.courseName;
                int n = p.courseCode;
                int o = p.courseCredit;

                Console.WriteLine(m);
                Console.WriteLine(n);
                Console.WriteLine(o);

            Console.ReadLine();
            }
        }
    
}
