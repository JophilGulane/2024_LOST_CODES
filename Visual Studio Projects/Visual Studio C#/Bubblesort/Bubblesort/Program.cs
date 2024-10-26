namespace Bubblesort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] numbers = { 99, 1, 3, 2, 8, 6, 9};


            Bubblesort(numbers);


            Console.WriteLine(numbers[^1]);


        }

        static void Bubblesort(int[] nums)
        {
            int n = nums.Length - 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                        
                    }
                }
            }
        }
    }
}
