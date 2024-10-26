using System;
namespace multiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication Table\n");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($" {i * j} \t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}