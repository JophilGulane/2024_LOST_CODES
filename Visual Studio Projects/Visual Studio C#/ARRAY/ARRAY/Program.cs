using System;

namespace programs
{
    class Loop
    {
        public static void Main(string[] args)
        {
            security();
            Console.ReadKey();
        }
        public static void security()
        {
            while (true)
            {
                string user, password;
                user = "ComputerScience";
                password = "Block2";

                Console.Write("Enter Username: ");
                string user_name = Console.ReadLine();
                Console.Write("Enter Password: ");
                string user_password = Console.ReadLine();

                if (user == user_name && password == user_password)
                {
                    main();
                }
                else
                {
                    Console.WriteLine("Incorrect Credential");
                }
            }
        }
        public static void main()
        {
            Console.Write("1 - Fibonacci\n2 - Factorial\n3 - Prime Numbers\n4 - Exit\n");
            Console.Write("Enter Module: ");
            string module = Console.ReadLine();

            switch (module)
            {
                case "1":
                    Fibonacci();
                    TryAgain();
                    break;
                case "2":
                    Factorial();
                    TryAgain();
                    break;
                case "3":
                    PrimeNumbers();
                    TryAgain();
                    break;
                case "4":     
                    Console.WriteLine("Logging Out...");
                    security();
                    break;
                default:
                    Console.WriteLine("Invalid Module!");
                    TryAgain();
                    break;
            }
        }
        public static void TryAgain()
        {
            Console.Write("Continue? (Y/N): ");
            string option = Console.ReadLine().ToLower();

            if (option == "y")
            {
                main();
            }
            else if (option == "n")
            {
                Console.WriteLine("Logging Out...");
            }
            else
            {
                Console.WriteLine("Invalid Module!");
                TryAgain();
            }
        }
        public static void Fibonacci()
        {
            int a, b, c;
            a = 0;
            b = 1;
            c = 0;

            Console.Write("Enter N of Fibonacci: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($" {c} ,");
                c = a + b;
                b = a;
                a = c;
            }
            Console.WriteLine();
        }
        public static void Factorial()
        {
            Console.Write("Enter N of Factorial: ");
            long factorial = 1;
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i}");
                if (i < n)
                {
                    Console.Write(" x ");
                }
                factorial *= i;
            }
            Console.WriteLine($" = {factorial}");
        }
        public static void PrimeNumbers()
        {
            Console.Write("Enter N of Prime Numbers: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                if (Prime(i))
                {
                    Console.Write($" {i} , ");
                }
            }
            Console.WriteLine();
        }

        public static bool Prime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

