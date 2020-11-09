using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Student
    {
        Book[] borrowBooks;
        private int borrowBookNumber;

        public int BorrowBookNumber
        {
            get { return borrowBookNumber; }
            set { borrowBookNumber = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string department;

        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        private float cgpa;

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        public Student()
        {
            Console.WriteLine("Empty Student Constructor .");
            borrowBooks = new Book[5];
        }
        public Student(String name, String id, string department, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;
        }
        public void AddBorrowBook(Book book)
        {
            if (borrowBookNumber < 5)
            {
                borrowBooks[borrowBookNumber++] = book;
            }

        }

        public void ShowBorrowBook()
        {
            foreach (var e in borrowBooks)
            {
                e.ShowInfo();
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Id : " + id);
            Console.WriteLine("Department : " + department);
            Console.WriteLine("CGPA : " + cgpa);
        }



    }
}