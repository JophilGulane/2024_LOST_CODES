namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("Ford");

            Console.WriteLine(Ford);
        }
    }

    class Car
    {
        private int speed;
        private string model;

        public Car(string model) 
        {
            this.speed = speed;
            this.model = model;
        }
    }
}
