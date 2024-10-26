using System;

namespace Program // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            Console.WriteLine("Hello World!");
                        Console.WriteLine("My name is Jays");
                        Console.Beep();

                        // This is a comment

                        *//* 
                         * this 
                         * is 
                         * a 
                         * multiline 
                         * comment 
                         *//*

                        Console.WriteLine("\nJays");

                        Console.ReadKey();
                        */

            /*            int x; //declaration
                        x = 123; //inizialization

                        int y = 321; 

                        Console.WriteLine(x + y);

                        Console.WriteLine(x);
                        Console.WriteLine(y);

                        double height = 1.64;

                        Console.WriteLine("My height is " +  height);

                        bool alive = true;

                        char sysbol = '@';

                        if (alive)
                        {
                            Console.WriteLine("I'm Alive");
                        }
                        else
                        {
                            Console.WriteLine("Dead");
                        }

                        Console.WriteLine("Enter Your Birthyear: ");
                        int age = 2024 - Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine("Your age is " + age);*/

            Random rand = new Random();


            int random = rand.Next(1, 7);

            Console.WriteLine(random);

            Console.ReadKey();
        }
    }
}