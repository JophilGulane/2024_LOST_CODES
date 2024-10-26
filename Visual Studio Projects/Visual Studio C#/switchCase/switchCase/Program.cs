using System;
namespace Switch
{
    class SwitchCase
    {
        public static void Main(string[] args)
        {
            int module;
            Console.Write("Enter a module number from 1-2: ");
            module = Convert.ToInt32(Console.ReadLine());

            switch (module)
            {
                case 1:
                    {
                        Console.Write("Enter a number: ");
                        int number = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= number; i++)
                        {
                            Console.WriteLine($"{i}\t {Math.Pow(i, 2)}\t {Math.Pow(i, 3)}");
                        }
                        break;
                    }

                case 2:
                    {
                        bool condition = true;
                        do
                        {
                            Console.Write("Enter temperature of  the water: ");
                            int temperature = Convert.ToInt32(Console.ReadLine());

                            if (temperature >= 100)
                            {
                                Console.WriteLine("Boiling Water");
                            }
                            else if (temperature >= 20)
                            {
                                Console.WriteLine("Warm Water");
                            }
                            else
                            {
                                Console.WriteLine("freezing water");
                            }

                            if (condition == true)
                            {
                                Console.Write("Do you want to continue y/n:");
                                string letter = Console.ReadLine().ToLower();

                                if (letter == "y")
                                {
                                    condition = true;
                                }
                                else if(letter == "n")
                                {
                                    condition = false;
                                    Console.WriteLine("Exiting Program...");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Input Try Again.");
                                }
                            }

                        } while (condition);
                        break;

                    }
                default:
                    {
                        Console.WriteLine("Invalid Module Number: ");
                        break;
                    }

            }

        }
    }
}