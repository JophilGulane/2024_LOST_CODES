
using System;

namespace Drills
{
    class Programs
    {
        static string correct_username = "BSCS";
        static string correct_password = "block2";
        static string[] student_vital_info = { "ID", "Last Name", "First Name", "Middle Name", "Program", "YearLevel", "Birthdate", "Address", "Status(Regular/Irregular)" };
        static string[] student_information = new string[9];
        static string[] math_books = { "Advance Algebra", "Calculus", "Calculus 2", "Trigonometry" };
        static int[] math_books_price = { 4395, 3565, 3465, 4345 };
        static double total = 0;
        static void Main(String[] args)
        {
            security();

        }

        static void security()
        {
            int number_of_retries = 3;
            while (number_of_retries > 0)
            {
                Console.Write("Enter Username: ");
                string username = Console.ReadLine();
                Console.Write("Enter Password: ");
                string password = Console.ReadLine();

                if (username == correct_username & password == correct_password)
                {
                    main();
                }
                else
                {
                    number_of_retries--;
                    Console.WriteLine($"Number of Retries Left: {number_of_retries}");

                }

                if (number_of_retries == 0)
                {
                    Console.WriteLine("Do you want to continue(y/n)");
                    string x = Console.ReadLine().ToLower();
                    if (x == "y")
                    {
                        number_of_retries = 3;
                    }
                    if (x == "n")
                    {
                        Console.WriteLine("Terminating Program");
                    }

                }
            }
        }

        static void modules()
        {
            Console.WriteLine("Module 1. Check Information");
            Console.WriteLine("Module 2. Math Book Store");
            Console.WriteLine("Module 3. Check Tuition Fee");
            Console.WriteLine("Module 4. Play a Game: ");
            Console.Write("Enter Module: ");
            string module = Console.ReadLine();

            switch (module)
            {
                case "1":
                    Case1();
                    modules();
                    break;
                case "2":
                    Case2();
                    modules();
                    break;
                case "3":
                    Case3();
                    modules();
                    break;
                case "4":
                    Case4();
                    modules();
                    break;
                default:
                    Console.WriteLine("Invalid Module!");
                    break;
            }
        }

        static void main()
        {
            for (int i = 0; i < student_information.Length; i++)
            {
                Console.Write($"Enter Your {student_vital_info[i]}: ");
                student_information[i] = Console.ReadLine();
            }

            modules();
        }

        static void Case1()
        {
            for (int i = 0; i < student_information.Length; i++)
            {
                Console.WriteLine($"{student_vital_info[i]}:  {student_information[i]}");
            }
        }

        static void Case2()
        {
            bool again = true;
            int book_quantity = 1;
            string user_cart = "";
            string checkout;

            do
            {
                Console.WriteLine("<--Available Books To Purchase -->");
                for (int i = 0; i < math_books.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. Name of Book: {math_books[i]} Price: {math_books_price[i]}");
                }

                Console.Write("Enter the number of the book you want to purchase: ");
                int book_id = int.Parse(Console.ReadLine()) - 1;


                Console.Write("Enter the quantity you want to buy: ");
                book_quantity = int.Parse(Console.ReadLine());

                total += math_books_price[book_id] * book_quantity;

                Console.WriteLine("<-- Items in Your Cart -->");
                user_cart += ($"{math_books[book_id]} Quantity:{book_quantity}\n");
                Console.WriteLine(user_cart);
                Console.Write("Do you want to purchase more books? (y/n): ");
                string user_option = Console.ReadLine().ToLower();

                if (user_option == "y")
                {
                    again = true;
                }
                else if (user_option == "n")
                {
                    Console.WriteLine("Do you want to checkout?(y/n)");
                    checkout = Console.ReadLine();
                    if (checkout == "y")
                    {
                        if (student_information[8].ToLower() == "regular")
                        {
                            total = total - (total * 0.10);
                            Console.WriteLine($"You Have 10% Discount as a Regular Student!");
                            Console.WriteLine($"Your total is {total}");
                        }
                        else
                        {
                            Console.WriteLine($"Your total is {total}");
                        }
                    }

                    else if (checkout == "n")
                    {

                    }
                    again = false;
                }
                else
                {
                    Console.WriteLine("Invalid Option Try again!");
                }
            } while (again);
        }

        static void Case3()
        {
            int tuition_fee_BSCS = 2000;
            int tuition_fee_BSIT = 1600;
            int MISC = 6500;
            int units = 0;
            int total_tuition_fee = 0;
            int tuition_fee_per_sem = 0;
            Console.Write("Are You a University Scholar? (y/n) ");
            string is_scholar = Console.ReadLine();

            if (is_scholar == "y")
            {
                MISC = 0;
                Console.WriteLine("Yo");
            }
            else if (is_scholar == "n")
            {
                MISC = 6500;
            }
            Console.Write("How Many Units Are You Enrolled in? ");
            units = int.Parse(Console.ReadLine());

            if (student_information[4].ToUpper() == "BSCS")
            {
                total_tuition_fee = (tuition_fee_BSCS * units) + MISC;
            }
            else if (student_information[4].ToUpper() == "BSIT")
            {
                total_tuition_fee = (tuition_fee_BSIT * units) + MISC;
            }

            tuition_fee_per_sem = total_tuition_fee / 3;


            Console.WriteLine($"Your total tuition fee is: {total_tuition_fee}");
            Console.WriteLine($"Your Tuition To Be Paid For The First Payment is {tuition_fee_per_sem}");
            Console.WriteLine($"Your Tuition To Be Paid For The Second Payment is {tuition_fee_per_sem}");
            Console.WriteLine($"Your Tuition To Be Paid For The Third Payment is {tuition_fee_per_sem}");
        }

        static void Case4()
        {
            string user_drawed_number;
            Console.WriteLine("Draw a number from 1-5");
            user_drawed_number = Console.ReadLine();

            switch (user_drawed_number)
            {
                case "1":
                    Console.WriteLine("You Win a Brand New Car!");
                    break;
                case "2":
                    Console.WriteLine("You Win a Brand iPhone 15 Pro Max Fully Paid!");
                    break;
                case "3":
                    Console.WriteLine("You Win a Brand New Laptop!");
                    break;
                case "4":
                    Console.WriteLine("You Win a Brand New Keyboard!");
                    break;
                case "5":
                    Console.WriteLine("You Win a Brand New Mouse!");
                    break;
                default:
                    break;
            }

        }
    }
}