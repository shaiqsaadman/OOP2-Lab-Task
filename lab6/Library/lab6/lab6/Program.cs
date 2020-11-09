using System;


namespace lab_6
{
    class Library
    {
        private string libName;

        public string LibName
        {
            get { return libName; }
            set { libName = value; }
        }
        private string libAddress;

        public string LibAddress
        {
            get { return libAddress; }
            set { libAddress = value; }
        }
        private Book[] listOfBook;
        private int totalBook;

        public int TotalBook
        {
            get { return totalBook; }
            set { totalBook = value; }
        }
        public Library()
        {
            listOfBook = new Book[100];
        }
        public Library(string libName, string libAddress)
        {
            this.libName = libName;
            this.libAddress = libAddress;
            TotalBook = 0;
        }
        public void ShowLibInfo()
        {
            Console.WriteLine("Library Name : " + libName);
            Console.WriteLine("Library Address : " + libAddress);
            Console.WriteLine("Total Number Of Books : " + totalBook);
        }
        public void ShowAllBooks()
        {
            foreach (var e in listOfBook)
            {
                e.ShowInfo();
            }
        }
        public void AddNewBook(Book book)
        {
            bool temp = false;
            for (int i = 0; i < listOfBook.Length; i++)
            {
                if (listOfBook[i] == null)
                {
                    listOfBook[i] = book;
                    TotalBook++;
                    temp = true;
                    break;

                }

            }
            if (temp)
            { Console.WriteLine("Book inserted ."); }
            else
                Console.WriteLine("Book inserted failed ");
        }

        public void DeleteBook(Book book)
        {
            for (int i = 0; i < totalBook; i++)
            {
                if (listOfBook[i].Equals(book))
                { listOfBook[i] = null; }
            }
        }
        public void AddNewBookCopy(Book book, int copy)
        {
            book.AddBookCopy(copy);
        }


    }
}