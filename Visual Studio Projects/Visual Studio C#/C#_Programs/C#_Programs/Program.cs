namespace CSharpPrograms
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 0;
            b = 1;
            int[] fibonacci = [0];

            Console.Write("Enter N of Fibonacci: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                c = a + b;

                fibonacci.Append(c);

                b = a;
                a = c;
            }
            Console.WriteLine(fibonacci);

            Console.ReadKey();
        }
    }
}