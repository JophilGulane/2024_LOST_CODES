using System;
using System.Collections.Generic;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Security())
            {
                Library library = new Library();
                library.Run();
            }
            else if (!Security())
            {
                Console.WriteLine("Invalid credentials.");
                return;
            }


        }

        static bool Security()
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            return username == "LIB" && password == "book";
        }
    }

    class Library
    {
        List<Book> books = new List<Book>
        {
            new Book("The Power of Now", "Eckhart Tolle"),
            new Book("Atomic Habits", "James Clear"),
            new Book("The 7 Habits of Highly Effective People", "Stephen R. Covey"),
            new Book("How to Win Friends and Influence People", "Dale Carnegie"),
            new Book("Man's Search for Meaning", "Viktor E. Frankl"),
            new Book("The Subtle Art of Not Giving a F*ck", "Viktor E. Frankl"),
            new Book("Man's Search for Meaning", "Mark Manson"),
            new Book("You Are a Badass", "Jen Sincero"),
            new Book("Daring Greatly", "Brené Brown"),
            new Book("Think and Grow Rich", "Viktor E. Frankl"),
            new Book("Mindset: The New Psychology of Success", "Carol S. Dweck")
        };

        List<Borrower> borrowers = new List<Borrower>
        {
            new Borrower("Faculty"),
            new Borrower("Staff"),
            new Borrower("Student")
        };

        List<Lib_Staff> libStaff = new List<Lib_Staff>
        {
            new Lib_Staff("Staff1"),
            new Lib_Staff("Staff2")
        };

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("1. Borrow Book");
                Console.WriteLine("2. Return Book");
                Console.WriteLine("3. Pay Fine");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        BorrowBook();
                        break;
                    case 2:
                        ReturnBook();
                        break;
                    case 3:
                        PayFine();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        void BorrowBook()
        {
            Borrower borrower = SelectBorrower();

            if (borrower == null)
            {
                Console.WriteLine("Invalid borrower type.");
                return;
            }

            if (borrower.Books.Count >= 3)
            {
                Console.WriteLine("You can't borrow more than 3 books.");
                return;
            }

            Book bookToBorrow = SelectBook(false);

            if (bookToBorrow == null)
            {
                Console.WriteLine("Book not available.");
                return;
            }

            borrower.Borrow(bookToBorrow);
            Console.WriteLine($"Book '{bookToBorrow.Title}' borrowed by {borrower.Type}.");
        }

        void ReturnBook()
        {
            Borrower borrower = SelectBorrower();

            if (borrower == null)
            {
                Console.WriteLine("Invalid borrower type.");
                return;
            }

            if (borrower.Books.Count == 0)
            {
                Console.WriteLine("No books to return.");
                return;
            }

            Book bookToReturn = SelectBook(true, borrower);

            if (bookToReturn == null)
            {
                Console.WriteLine("Invalid book title.");
                return;
            }

            borrower.Return(bookToReturn);
            Console.WriteLine($"Book '{bookToReturn.Title}' returned by {borrower.Type}.");
        }

        void PayFine()
        {
            Borrower borrower = SelectBorrower();

            if (borrower == null)
            {
                Console.WriteLine("Invalid borrower type.");
                return;
            }

            int fine = borrower.CalculateFine();
            if (fine > 0)
            {
                Console.WriteLine($"You have a fine of {fine}. Please pay.");
                Console.WriteLine("Enter amount to pay: ");
                int amount = int.Parse(Console.ReadLine());

                if (amount >= fine)
                {
                    borrower.PayFine(amount);
                    Console.WriteLine("Fine paid successfully.");
                }
                else
                {
                    Console.WriteLine("Insufficient amount. Please pay the full fine.");
                }
            }
            else
            {
                Console.WriteLine("No fine to pay.");
            }
        }

        Borrower SelectBorrower()
        {
            Console.WriteLine("Select borrower type:");
            for (int i = 0; i < borrowers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {borrowers[i].Type}");
            }
            int borrowerOption = int.Parse(Console.ReadLine());
            if (borrowerOption >= 1 && borrowerOption <= borrowers.Count)
            {
                return borrowers[borrowerOption - 1];
            }
            return null;
        }

        Book SelectBook(bool onlyBorrowed, Borrower borrower = null)
        {
            Console.WriteLine("Select book:");
            List<Book> availableBooks = onlyBorrowed ? borrower.Books : books.FindAll(b => !b.IsBorrowed);
            for (int i = 0; i < availableBooks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {availableBooks[i].Title} by {availableBooks[i].Author}");
            }
            int bookOption = int.Parse(Console.ReadLine());
            if (bookOption >= 1 && bookOption <= availableBooks.Count)
            {
                return availableBooks[bookOption - 1];
            }
            return null;
        }
    }

    class Book
    {
        public string Title { get; }
        public string Author { get; }
        public bool IsBorrowed { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            IsBorrowed = false;
        }
    }

    class Borrower
    {
        public string Type { get; }
        public List<Book> Books { get; }
        private DateTime borrowDate;
        private int fine;

        public Borrower(string type)
        {
            Type = type;
            Books = new List<Book>();
            fine = 0;
        }

        public void Borrow(Book book)
        {
            Books.Add(book);
            book.IsBorrowed = true;
            borrowDate = DateTime.Now;
        }

        public void Return(Book book)
        {
            Books.Remove(book);
            book.IsBorrowed = false;
        }

        public int CalculateFine()
        {
            TimeSpan borrowDuration = DateTime.Now - borrowDate;
            int days = borrowDuration.Days;

            if (days > 3 && days <= 5)
            {
                fine = 50 * (days - 3);
            }
            else if (days > 5)
            {
                fine = (50 * 2) + 100 * (days - 5);
                Console.WriteLine("Memo: Fine has increased.");
            }

            return fine;
        }

        public void PayFine(int amount)
        {
            fine -= amount;
        }
    }

    class Lib_Staff
    {
        public string Name { get; }

        public Lib_Staff(string name)
        {
            Name = name;
        }
    }
}