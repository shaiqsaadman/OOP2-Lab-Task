using System;



namespace Student

{

    class Program

    {

        private string name;
        private string id;
        public string department;
        private float cgpa;

        public string Name

        {

            get

            {

                return name;

            }

            set

            {

                name = value;

            }

        }

        public string ID

        {

            get

            {

                return id;

            }

            set

            {

                id = value;

            }

        }

        public string Department

        {

            get

            {

                return department;

            }

            set

            {

                department = value;

            }

        }

        public string Cgpa

        {

            get

            {

                return cgpa;

            }

            set

            {

               cgpa = value;

            }

        }

    }

    class Program

    {

        static void Main(string[] args)

        {

            Student s = new Student();

            s.Name = "Shaiq";

            s.Location = "Department";

            Console.WriteLine("Name: " + s.Name);


            Console.WriteLine("department: " + s.department);

            Console.WriteLine("ID: " + s.id);

            Console.WriteLine("CGPA " + s.cgpa);


            Console.WriteLine("\nPress Enter Key to Exit..");

            Console.ReadLine();

        }

    }

}