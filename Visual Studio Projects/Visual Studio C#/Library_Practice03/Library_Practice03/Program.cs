using System.Security.Permissions;

namespace Library_Practice03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (Security())
            {
                Library lib = new Library();
                lib.Run();
            }
        }

        public static bool Security()
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();
            Console.Write("Enter Password: ");
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
            new Book("Book_3", "Author_3")
        };

        List<Borrower> borrowers = new List<Borrower>()
        {
            new Borrower("Faculty"),
            new Borrower("Staff"),
            new Borrower("Student"),
        };
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Enter Action: ");
            Console.WriteLine("1. Borrow");
            Console.WriteLine("2. Return");
            Console.WriteLine("3. Pay");

            string user_action = Console.ReadLine();

                switch (user_action)
                {
                    case "1":
                        BorrowBook();
                        break;

                    case "2":
                        ReturnBook(); 
                        break;

                    case "3":
                        PayFine();
                        break;
                }
            }
        }

        public void BorrowBook()
        {
            Borrower borrower = SelectBorrower();

            if (borrower == null)
            {
                Console.WriteLine("Not Found");
            }
            
            else if (borrower.Books.Count >= 3)
            {
                Console.WriteLine("Can't Borrow More Than 3 Books");
            }

            else
            {
                Book bookToBorrow = SelectBook(false, borrower);
                borrower.Borrow(bookToBorrow);
                Console.WriteLine(bookToBorrow.bookName);
            }
        }

        public void ReturnBook()
        {
            Borrower borrower = SelectBorrower();

            if (borrower == null)
            {
                Console.WriteLine("Not Found");

            }

            else if (borrower.Books.Count == 0)
            {
                Console.WriteLine("No Books To Return");
            }

            else
            {
                Book bookToReturn = SelectBook(true, borrower);
                borrower.Return(bookToReturn);
                Console.WriteLine(bookToReturn.bookName);
            
            }
        }

        public void PayFine()
        {
            Borrower borrower = SelectBorrower();
            if (borrower == null)
            {
                Console.WriteLine("Not Found");
            }


            Console.WriteLine("Enter The Number of Days Borrowed: ");
            int borrowedDays = int.Parse(Console.ReadLine());

            borrower.Fines(borrowedDays);
            Console.WriteLine("Fines Pay Successfully");


        }
        Borrower SelectBorrower()
        {
            Console.WriteLine("Select User: ");
            for (int i = 0; i < borrowers.Count; i++)
            {
                Console.WriteLine($"{i+1}.{borrowers[i].Type}");
            }
            int borrowerOption = int.Parse(Console.ReadLine());
            if (borrowerOption >= 1 && borrowerOption <= borrowers.Count)
            {
                return borrowers[borrowerOption -1];
            }
            return null;
        }

        Book SelectBook(bool isBorrowed, Borrower borrower)
        {
            Console.WriteLine("Available Books: ");
            List<Book> availableBooks = isBorrowed ? borrower.Books : books.FindAll(b => !b.isBorrowed);

            for (int i = 0; i < availableBooks.Count;i++)
            {
                Console.WriteLine($"{i + 1}.{availableBooks[i].bookName}");
            }

            int bookOption = int.Parse(Console.ReadLine());
            if (bookOption >= 1 && bookOption <= books.Count)
            {
                return availableBooks[bookOption -1];
            }
            return null;
        }
    }

    class Book
    {
        public string bookName;
        public string bookAuthor;
        public bool isBorrowed;

        public Book(string bookName, string bookAuthor)
        {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            isBorrowed = false;
        }
    }

    class Borrower
    {
        public string Type;
        public List<Book> Books;
        int fine;

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
            if (day > 3)
            {
                day = day - 3;
                fine += day * 50;

            }

            else if (day > 5) 
            {
                day = day - 3;
                fine += day * 100;
            }
            Console.WriteLine("Fine to be pay: "+ fine);
        }
    }

}
