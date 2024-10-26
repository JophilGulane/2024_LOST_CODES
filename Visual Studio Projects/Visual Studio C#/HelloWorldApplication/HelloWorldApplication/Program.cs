using System;

namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apple", "banana", "cherry", "mango" };
            


            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < fruits.Length; i++)
            {

                Console.WriteLine(fruits[i]);
            }

            Console.ReadKey();

        }

        private void sum(int x, int y)
        {
            Console.WriteLine(x + y);
        }
    }
}
