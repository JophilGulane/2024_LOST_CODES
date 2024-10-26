namespace PizzaKiosk2
{
    internal class Program
    {
        static string[] AddOnsArray = { "Cheese", "MozzarellaCheese", "Pepper", "BaconHam", "Mushroom", "OnionsChili", "Tomato", "Pineapple", "Salami" };
        static int DefaultPizzaPrice = 450;
        static int Bill = 0;
        static string[] FinalPizzaChoice = new string[3];
        static string[] DeluxeAddOns = { "Cheese", "BaconHam", "Onions Chili" };
        static string[] SpecialAddOns = { "Cheese", "Pepper", "BaconHam", "Mushroom", "Onions Chili" };
        static string[] PrimoAddOns = { "Mozzarella Cheese", "Pepper", "Bacon Ham", "Mushroom", "Onions Chili", "Tomato", "Pineapple", "Salami" };
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pizza Kiosk");

            Console.Write("Enter the Customers Name: ");

            FinalPizzaChoice[0] = Console.ReadLine();

            Console.WriteLine("1. Deluxe Pizza Add Ons");
            Console.WriteLine("2. Special Pizza Add Ons");
            Console.WriteLine("3. Primo Pizza Add Ons");
            Console.Write("Enter Preferred Pizza: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    FinalPizzaChoice[1] = "Deluxe";
                    DeluxeFunction(100, 120, 110);
                    break;
                case "2":
                    FinalPizzaChoice[1] = "Special";
                    SpecialFunction(100, 80, 120, 130, 110);
                    break;
                case "3":
                    FinalPizzaChoice[1] = "Primo";
                    PrimoFunction(150, 80, 120, 130, 110, 90, 100, 120);
                    break;
                default:
                    break;

            }
        }

        static void DeluxeFunction(int Cheese, int BaconHam, int OnionsChili)
        {
            Console.WriteLine($"Preferred Pizza: {FinalPizzaChoice[1]}");
            Console.WriteLine($"Details:");
            Console.WriteLine($"Base: {DefaultPizzaPrice}");
            foreach (string i in DeluxeAddOns)
            {
                Console.WriteLine(i);
            }

            Bill = DefaultPizzaPrice + Cheese + BaconHam + OnionsChili;
            FinalPizzaChoice[2] = Convert.ToString(Bill);
            Console.WriteLine();
            Console.WriteLine($"Customer: {FinalPizzaChoice[0]}");
            Console.WriteLine($"Pizza Preference: {FinalPizzaChoice[1]}");
            Console.WriteLine($"Bill: {FinalPizzaChoice[2]}");

        }

        static void SpecialFunction(int Cheese, int Pepper, int BaconHam, int Mushroom, int OnionsChili)
        {
            Console.WriteLine($"Preferred Pizza: {FinalPizzaChoice[1]}");
            Console.WriteLine($"Details:");
            Console.WriteLine($"Base: {DefaultPizzaPrice}");
            foreach (string i in SpecialAddOns)
            {
                Console.WriteLine(i);
            }
            Bill = DefaultPizzaPrice + Cheese + Pepper + BaconHam + Mushroom + OnionsChili;
            FinalPizzaChoice[2] = Convert.ToString(Bill);
            Console.WriteLine();
            Console.WriteLine($"Customer: {FinalPizzaChoice[0]}");
            Console.WriteLine($"Pizza Preference: {FinalPizzaChoice[1]}");
            Console.WriteLine($"Bill: {FinalPizzaChoice[2]}");
        }

        static void PrimoFunction(int MozzarellaCheese, int Pepper, int BaconHam, int Mushroom, int OnionsChili, int Tomato, int Pineapple, int Salami)
        {
            Console.WriteLine($"Preferred Pizza: {FinalPizzaChoice[1]}");
            Console.WriteLine($"Details:");
            Console.WriteLine($"Base: {DefaultPizzaPrice}");
            foreach (string i in PrimoAddOns)
            {
                Console.WriteLine(i);
            }
            Bill = DefaultPizzaPrice + MozzarellaCheese + Pepper + BaconHam + Mushroom + OnionsChili + Tomato + Pineapple + Salami;
            FinalPizzaChoice[2] = Convert.ToString(Bill);
            Console.WriteLine();
            Console.WriteLine($"Customer: {FinalPizzaChoice[0]}");
            Console.WriteLine($"Pizza Preference: {FinalPizzaChoice[1]}");
            Console.WriteLine($"Bill: {FinalPizzaChoice[2]}");
        }
    }
}
