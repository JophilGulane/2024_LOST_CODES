using System;

class Program
{
    static string correct_username = "PSU";
    static string correct_password = "Block2";

    static void Main()
    {
        bubbleSort();
        security();
        Console.ReadKey();
    }

    static void security()
    {
        int number_of_retries = 3;
        while (number_of_retries > 0)
        {
            Console.WriteLine("Enter Username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();

            if (username == correct_username && password == correct_password)
            {
                main();
                break;
            }

            else
            {
                number_of_retries--;
                Console.WriteLine($"Wrong Password Tries Left: {number_of_retries}");
            }
        }
    }

    static void main()
    {
        Console.WriteLine("Enter Module: ");
        string module = Console.ReadLine();

        switch (module)
        {
            case "1":
                bubbleSort();
                break;
        }
    }

    static void bubbleSort()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < 5 ; i++)
        {
            Console.WriteLine($"Enter Number {i}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int n = numbers.Length - 1;
       

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }

        Console.WriteLine($"The biggest number is {numbers[^1]}");

        foreach (var i in numbers)
        {
            Console.Write(i + " ");
        }
    }
}




























/*    static int ReverseDigits(int number)
    {
        int reversedNumber = 0;

        while (number != 0)
        {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
            number /= 10;
        }

        return reversedNumber;
    }*/

    /*        Console.WriteLine("Enter the number of rows:");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }*/
    /*        int n = 5;


            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.WriteLine(new string('*' , 2 * i - 1));
            }
            for (int i = n - 1; i >= 1; i--)
            {
                Console.Write(new string(' ', n - i));
                Console.WriteLine(new string('*', 2 * i - 1));
            }*/




    /*        int n = 5; // Change this to set the size of the diamond

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.WriteLine(new string('*', 2 * i - 1));
            }

            for (int i = n - 1; i >= 1; i--)
            {
                Console.Write(new string(' ', n - i));
                Console.WriteLine(new string('*', 2 * i - 1));
            }*/






























    /*
            Console.Write("Enter how many student: ");
            int number_of_students = int.Parse(Console.ReadLine());
            number_of_students += 1;
            string[,] students = new string[number_of_students, 3];

            students[0, 0] = "Name";
            students[0, 1] = "Course";
            students[0, 2] = "Block";

            for (int i = 1; i < number_of_students; i++)
            {
                Console.WriteLine($"Enter the information for student {i}");
                Console.WriteLine($"Enter the Name of the student {i}: ");
                students[i, 0] = Console.ReadLine();
                Console.WriteLine($"Enter the Course of the student {i}: ");
                students[i, 1] = Console.ReadLine();
                Console.WriteLine($"Enter the Block of the student {i}: ");
                students[i, 2] = Console.ReadLine();
            }

            for (int i = 0; i < students.GetLength(0); i++)
            {
                for (int j = 0; j < students.GetLength(1); j++)
                {
                    Console.Write(students[i,j] + "\t");
                }
                Console.WriteLine();
            }*/
































    /*        string[] informations = {"Name: ", "Block: ", "Course: " };
            string[] student_info = new string[informations.Length];

            for (int i = 0; i < informations.Length; i++)
            {
                Console.Write(informations[i]);
                student_info[i] = Console.ReadLine();
            }

            for (int i = 0; i < informations.Length; i++)
            {
                Console.Write(informations[i]);
                Console.WriteLine(student_info[i]);
            }*/


























    /*        Console.Write("Enter number of students: ");
            int number_of_students = int.Parse(Console.ReadLine());
            string[,] students = new string[number_of_students, 3];

            for (int i = 0; i < students.GetLength(0); i++)
            {
                Console.WriteLine($"Enter Student {i+1} Informations ");
                Console.Write("Enter Name: ");
                students[i, 0] = Console.ReadLine();
                Console.Write("Enter Course: ");
                students[i, 1] = Console.ReadLine();
                Console.Write("Enter Block: ");
                students[i, 2] = Console.ReadLine();
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < students.GetLength(0);i++)
            {
                Console.WriteLine($"Student {i+1} Informations");
                Console.Write($"Name:{students[i,0]} Course:{students[i,1] } Block:{students[i,2]}\n");
                Console.WriteLine();
            }

            Console.WriteLine(students[0,0]);*/





























    /*        Console.Write("Enter how many students to register: ");
    string[,] students = new string[int.Parse(Console.ReadLine()), 3];
    for (int i = 0; i < students.GetLength(0); i++)
    {
        Console.WriteLine($"Enter Student {(i + 1)}  Informations ");
        Console.Write("Name: ");
        students[i, 0] = Console.ReadLine();
        Console.Write("Grade: ");
        students[i, 1] = Console.ReadLine();
        Console.Write("Section: ");
        students[i, 2] = Console.ReadLine();
    }   
    Console.WriteLine("The students' names and grades are: ");
    for (int i = 0; i < students.GetLength(0); i++)
    {
        Console.WriteLine("Name: " + students[i, 0] + " Grade: " + students[i, 1] + " Section: " + students[i, 2]);
    }*/
    /*        int n = 4;
            bool isPriime;

            isPriime = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isPriime = false;
                }
            }



                Console.WriteLine(isPriime);*/


    /*       

            Console.WriteLine(Prime(3));

            for (int i = 2; i <= 50; i++)
            {
                if (isPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
    */



/*    static bool isPrime(int n)
    {
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }*/


















/*     static bool Prime(int n)
    {
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}*/