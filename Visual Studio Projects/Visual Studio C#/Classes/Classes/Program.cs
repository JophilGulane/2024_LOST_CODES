using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Jophil", 19);
            Console.WriteLine(human.Name);

            Human human1 = new Human("Tracy", 19);

            human1.Eat();
            
        }
    }

    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Human(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void Eat()
        {
            Console.WriteLine(Name + " is eating");
        }
    }
}


