using System;

namespace IsPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            bool palindrome = isPalindrome(Console.ReadLine());
            if(palindrome)
            {
                Console.WriteLine("Is Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
            Console.ReadKey();
        }

        static bool isPalindrome(string input)
        {
            char[] Cinput = input.ToCharArray();
            Array.Reverse(Cinput);
            string rev = Convert.ToString(Cinput);

            Console.WriteLine(rev);

            if (input == rev)
            {
                return true;
            }
            else
            {
                return false;
            }



        }
    }
}
