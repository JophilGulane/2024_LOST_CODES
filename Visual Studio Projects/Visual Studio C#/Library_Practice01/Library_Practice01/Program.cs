using System.Security.Permissions;

namespace Library_Practice01
{
    class Program
    {
        public static void Main(string[] args)
        {
            if (Security())
            {
                Library lib = new Library();
                while (true)
                {
                    lib.Run();
                }

            }
        }

        public static bool Security()
        {
            Console.WriteLine("Enter Username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();

            return username == "LIB" && password == "book";
        }
    }

    class Library
    {
        List<Book> books = new List<Book>()
        {
            new Book("Book_1", "Author_1"),
            new Book("Book_2", "Author_2"),
            new Book("Book_3", "Author_3"),
            new Book("Book_4", "Author_4"),
            new Book("Book_5", "Author_5")
        };

        List<Borrower> borrowers = new List<Borrower>()
        {
            new Borrower("Faculty"),
            new Borrower("Staff"),
            new Borrower("Student")
        };

        public void Run()
        {
            Console.WriteLine("Select Action: ");
            Console.WriteLine("1. Borrow Book ");
            Console.WriteLine("2. Return Book ");
            Console.WriteLine("3. Pay Fines");

            string userAction = Console.ReadLine();

            switch (userAction)
            {
                case "1":
                    borrowBook();
                    break;
                case "2":
                    returnBook();
                    break;
                case "3":
                    payFines();
                    break;
            }
        }

        public void borrowBook()
        {
            Borrower borrower = SelectBorrower();

            if (borrower == null)
            {
                Console.WriteLine("Borrower Not Found");
            }
            else if (borrower.Books.Count >= 3) 
            {
                Console.WriteLine("Maximum Book to Borrow is 3");
            }
            else
            {
                Book bookToBorrow = SelectBook(false, borrower);
                borrower.Borrow(bookToBorrow);
                Console.WriteLine($"{bookToBorrow.bookTitle} is successfully borrowed by {borrower.Type}");
            }
        }

        public void returnBook()
        {
            Borrower borrower = SelectBorrower();

            if (borrower == null)
            {
                Console.WriteLine("Borrower Not Found");
            }
            else if (borrower.Books.Count == 0)
            {
                Console.WriteLine("No Books Borrowed");
            }
            else
            {
                Book bookToReturn = SelectBook(true, borrower);
                borrower.Return(bookToReturn);
                Console.WriteLine($"{bookToReturn.bookTitle} is successfully Returned by {borrower.Type}");
            }
        }

        public void payFines()
        {
            Borrower borrower = SelectBorrower();

            if (borrower == null)
            {
                Console.WriteLine("Borrower Not Found");
            }
            else if (borrower.Books.Count == 0)
            {
                Console.WriteLine("No Books Borrowed");
            }
            else
            {
                Console.WriteLine("Enter Number of days borrowed: ");
                int daysBorrowed = int.Parse(Console.ReadLine());
                borrower.Fines(daysBorrowed);
            }
        }

        Borrower SelectBorrower() 
        {
            Console.WriteLine("Select Borrower: ");
            for (int i = 0; i < borrowers.Count; i++) 
            {
                Console.WriteLine($"{i + 1}.{borrowers[i].Type}");
            }
            int borrowerOption = int.Parse(Console.ReadLine());
            if (borrowerOption >= 1 && borrowerOption <= borrowers.Count) 
            { 
                return borrowers[borrowerOption - 1];
            }
            else
            {
                return null;
            }
        }

        Book SelectBook(bool isBorrowed, Borrower borrower)
        {
            Console.WriteLine("Available Books: ");
            List<Book> availableBooks = isBorrowed ? borrower.Books : books.FindAll(book => !book.isBorrowed);
            for (int i = 0; i < availableBooks.Count;i++)
            {
                Console.WriteLine($"{i+1}. {availableBooks[i].bookTitle}, {availableBooks[i].bookAuthor}");
            }
            int bookOption = int.Parse( Console.ReadLine() ) ;
            if (bookOption >= 1 && bookOption <= books.Count)
            {
                return availableBooks[bookOption - 1];
            }
            else
            {
                return null;
            }
        }
    }

    class Book
    {
        public string bookTitle;
        public string bookAuthor;
        public bool isBorrowed;

        public Book(string bookTitle, string bookAuthor)
        {
            this.bookTitle = bookTitle;
            this.bookAuthor = bookAuthor;

        }
    }

    class Borrower
    {
        public string Type;
        public List<Book> Books;
        public int fine;

        public Borrower(string Type)
        {
            this.Type = Type;
            Books = new List<Book>();
            fine = 0;
        }

        public void Borrow(Book book)
        {
            Books.Add(book);
            book.isBorrowed = true;
        }

        public void Return(Book book) 
        {
            Books.Remove(book);
            book.isBorrowed = false;
        }

        public void Fines(int day)
        {
            if (day > 5)
            {
                fine += (day - 5) * 100;
                day = 5;
                
            }

            if (day > 3) 
            {
                fine += (day - 3);

            }
            Console.WriteLine(fine);
        }
    }
}