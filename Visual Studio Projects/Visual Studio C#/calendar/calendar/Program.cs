using System;

namespace calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Month Number: ");
            int month = Convert.ToInt32(Console.ReadLine());
            
            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    PrintMonth(month);
                    break;
                case 2:
                    Console.WriteLine("February");
                    PrintMonth(month);
                    break;
                case 3:
                    Console.WriteLine("March");
                    PrintMonth(month);
                    break;
                case 4:
                    Console.WriteLine("April");
                    PrintMonth(month);
                    break;
                case 5:
                    Console.WriteLine("May");
                    PrintMonth(month);
                    break;
                case 6:
                    Console.WriteLine("June");
                    PrintMonth(month);
                    break;
                case 7:
                    Console.WriteLine("July");
                    PrintMonth(month);
                    break;
                case 8:
                    Console.WriteLine("August");
                    PrintMonth(month);
                    break;
                case 9:
                    Console.WriteLine("September");
                    PrintMonth(month);
                    break;
                case 10:
                    Console.WriteLine("October");
                    PrintMonth(month);
                    break;
                case 11:
                    Console.WriteLine("November");
                    PrintMonth(month);
                    break;
                case 12:
                    Console.WriteLine("December");
                    PrintMonth(month);
                    break;
                default:
                    Console.WriteLine("Invalid month");
                    break;
            }   
            



        }

        static void PrintMonth(int month)
        {
            int monthDay = 0;

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                monthDay = 31;
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                monthDay = 30;
            }

            else if (month == 2)
            {
                monthDay = 28;
            }


           for (int i = 1; i <= monthDay; i++)
            {
                Console.Write(i + "\t");
                if (i % 7 == 0)
                {
                    Console.WriteLine();
                }
            } 
        }   
    }
}