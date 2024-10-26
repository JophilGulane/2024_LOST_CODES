using Microsoft.VisualBasic.FileIO;
using System;
using System.Runtime.InteropServices;
namespace ATM
{
    class Program
    {
        static double balance = 50000;
        static bool option = true;
        public static void Main(string[] args)
        {
            password();
        }
        static void main()
        {


            while (option)
            {
                Console.WriteLine("");
                Console.WriteLine("Welcome to Jays ATM");
                Console.WriteLine("<--- Please Select Action --->");
                Console.WriteLine("1. CHECK BALANCE");
                Console.WriteLine("2. DEPOSIT");
                Console.WriteLine("3. WITHDRAW");
                Console.WriteLine("4. EXIT");
                Console.Write("Select Action: ");

                string action = Console.ReadLine();

                switch (action)
                {
                    case "1":
                        CheckBalance();
                        break;
                    case "2":
                        Deposit();
                        break;
                    case "3":
                        Withdraw();
                        break;
                    case "4":
                        Exit();
                        break;
                    default:
                        Console.WriteLine("Invalid Action \n Please Try Again...");
                        break;
                }


            } 
        }

        static void CheckBalance()
        {
            Console.WriteLine($"Your Current Balance is {balance}");
        }

        static void Deposit()
        {
            Console.Write($"Enter The Amount You Want To Deposit:");
            double deposit = Convert.ToDouble(Console.ReadLine());

            if (deposit > 0)
            {
                balance = balance + deposit;
                Console.WriteLine($"Your New Balance is {balance}");
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }

        }

        static void Withdraw()
        {
            Console.Write($"Enter The Amount You Want To Withdraw:");
            double withdraw = Convert.ToDouble(Console.ReadLine());
            if (withdraw > 0 && balance >= withdraw)
            {
                balance = balance - withdraw;
                Console.WriteLine($"Your New Balance is {balance}");
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }

        }

        static void Exit()
        {
            Console.WriteLine("Exiting Program...");
            option = false;
        }
        static void password()
        {
            string correct_PIN = "456852";

            Console.WriteLine("Jays ATM");
                
            for (int i = 2; i >= 0; i--)
            {
                Console.Write("Please Input PIN: ");
                string user_input_PIN = Console.ReadLine();

                if (user_input_PIN == correct_PIN)
                {
                    Console.WriteLine("Login Successfully");
                    main();
                    break;
                }
                else if (i == 0)
                {
                    Console.WriteLine("Failed attempt");
                    Console.WriteLine("Exiting Program...");
                }
                else
                {
                    Console.WriteLine($"Incorrect PIN");
                    Console.WriteLine($"You have {i} attempts left");
                }
            }
        }
    }
}

