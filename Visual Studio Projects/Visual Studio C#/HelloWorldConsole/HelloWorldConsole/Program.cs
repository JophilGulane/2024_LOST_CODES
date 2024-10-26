using System;

namespace HelloWorldConsole
{
    class Hello
    {
        static void Main(string[] args)
        {

            string username = "BSCS", password = "block2";

            bool choosen = true;
            
                //Get username and password from user
                Console.Write("Enter Username: ");
                string inputUsername = Console.ReadLine();
                Console.Write("Enter Password: ");
                string inputPassword = Console.ReadLine();

                //Check if username and password are correct
                if (inputUsername == username && inputPassword == password)
                {
                Console.WriteLine("Login Successful ");

                    while (choosen)
                    {
                        string lastName, firstName;
                        int dependents;
                        double grossSalary, tax;
                        const double GSIS = 2500, HDMF = 410;
                        
                        //Get user input
                        Console.Write("Enter Lastname: ");
                        lastName = Console.ReadLine();
                        Console.Write("Enter Firstname: ");
                        firstName = Console.ReadLine();
                        Console.Write("Enter no. of dependents: ");
                        dependents = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter gross salary: ");
                        grossSalary = Convert.ToDouble(Console.ReadLine());

                        //Compute tax
                        if (dependents == 0)
                        {
                            tax = grossSalary * 0.2;
                            grossSalary = grossSalary - tax;
                        }

                        else if (dependents >= 1 && dependents <= 3)
                        {
                            tax = grossSalary * 0.10;
                            grossSalary = grossSalary - tax;

                        }
                        else if (dependents >= 4)
                        {
                            tax = 0;

                        }
                        //Display output
                        Console.WriteLine($"Gross Salary with tax {grossSalary - (GSIS + HDMF)}");

                        //Ask user if they want to continue
                        Console.WriteLine("Do you want to continue? (Y/N)");
                        string choice = Console.ReadLine().ToLower();
                        if (choice == "y")
                        {
                            choosen = true;
                        }
                        else if (choice == "n")
                        {
                            choosen = false;
                            Console.WriteLine("Exiting Program...");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input");
                        }
                    }

            }

            else
            {
                Console.WriteLine("Invalid Username or Password");
            }

            Console.ReadKey() ;
        }
    }
}