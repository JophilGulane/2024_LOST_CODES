using System;

namespace PizzaKiosk
{
    class Pizza
    {
        static string[] AddOnsArray = {"Cheese", "MozzarellaCheese", "Pepper", "BaconHam", "Mushroom", "OnionsChili", "Tomato", "Pineapple", "Salami"};
        static string[] DeluxeAddOns = {"Cheese", "Bacon Ham", "Onions Chili"};
        static string[] SpecialAddOns = {"Cheese", "Pepper", "Bacon Ham", "Mushrooms", "Onions Chili"};
        static string[] PrimoAddOns = {"Mozzarella Cheese", "Pepper", "Bacon Ham", "Mushroom", "Onions Chili", "Tomato", "Pineapple", "Salami"};

        static string[] FinalPizzaChoice = new string[3];
        static int base_price = 450;

        static void Main(string[] args)
        {
            SelectPizza();
            Console.ReadKey();
        }
        static void SelectPizza()
        {
            Console.WriteLine("Welcome to the Pizza Kiosk!");

            Console.Write("Enter the Customers Name: ");
            FinalPizzaChoice[0] = Console.ReadLine();

            Console.WriteLine("1. Deluxe");
            Console.WriteLine("2. Special");
            Console.WriteLine("3. Primo");
            Console.Write("Choose your pizza:");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    FinalPizzaChoice[1] = "Deluxe";
                    DeluxeFunction(100,120,110);
                    break;
                case 2:
                    FinalPizzaChoice[1] = "Special";
                    SpecialFunction(100,80,120,130,110);
                    break;
                case 3:
                    FinalPizzaChoice[1] = "Primo";
                    PrimoFunction(150,80,120,130,110,90,100,120);
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }

        static void DeluxeFunction(int Cheese = 100, int BaconHam = 120, int OnionsChili = 110)
        {
            Console.WriteLine($"Preferred Pizza: {FinalPizzaChoice[1]}");
            Console.Write($"Details:\nBase: {base_price}\n");
            foreach (string i in DeluxeAddOns)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            base_price += Cheese + BaconHam + OnionsChili;
            FinalPizzaChoice[2] = Convert.ToString(base_price);
            Console.WriteLine($"Customer: {FinalPizzaChoice[0]}");
            Console.WriteLine($"Pizza Preference: {FinalPizzaChoice[1]}");
            Console.WriteLine($"Bill: {FinalPizzaChoice[2]}");
        }


        static void SpecialFunction(int Cheese = 100, int Pepper = 80, int BaconHam = 120, int Mushroom = 130, int OnionsChili = 110)
        {
            Console.WriteLine($"Preferred Pizza: {FinalPizzaChoice[1]}");
            Console.Write($"Details:\nBase: {base_price}\n");
            foreach (string i in SpecialAddOns)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            base_price += Cheese + Pepper + BaconHam + Mushroom + OnionsChili;
            FinalPizzaChoice[2] = Convert.ToString(base_price);
            Console.WriteLine($"Customer: {FinalPizzaChoice[0]}");
            Console.WriteLine($"Pizza Preference: {FinalPizzaChoice[1]}");
            Console.WriteLine($"Bill: {FinalPizzaChoice[2]}");
        }

        static void PrimoFunction(int MozzarellaCheese = 150, int Pepper = 80, int BaconHam = 120, int Mushroom = 130, int OnionsChili = 110, int Tomato = 90, int Pineapple = 100, int Salami = 120)
        {
            Console.WriteLine($"Preferred Pizza: {FinalPizzaChoice[1]}");
            Console.Write($"Details:\nBase: {base_price}\n");
            foreach (string i in PrimoAddOns)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            base_price += MozzarellaCheese + Pepper + BaconHam + Mushroom + OnionsChili + Tomato + Pineapple + Salami;
            FinalPizzaChoice[2] = Convert.ToString(base_price);
            Console.WriteLine($"Customer: {FinalPizzaChoice[0]}");
            Console.WriteLine($"Pizza Preference: {FinalPizzaChoice[1]}");
            Console.WriteLine($"Bill: {FinalPizzaChoice[2]}");
        }
    }
}
