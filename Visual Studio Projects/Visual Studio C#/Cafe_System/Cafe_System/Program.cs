using Microsoft.VisualBasic;

namespace Cafe_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (Security())
            {
                Cafe cafe = new Cafe();
                bool again = false;
                do
                {
                    cafe.Run();

                    Console.WriteLine("Another Transaction? Y/N?");
                    string AGAIN = Console.ReadLine().ToLower();
                    if (AGAIN == "y")
                    {
                        again = true;
                    }
                    else
                    {
                        Console.WriteLine("Thank You!");
                        Console.WriteLine("Comeback Again!");
                        again = false;
                    }
                } while (again);

            }
            else
            {
                Console.WriteLine("Invalid Username of Password");
            }
        }

        static bool Security()
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            return (username == "Cafe" && password == "Admin8@") ? true : false;
        }
    }

    class Cafe
    {
        List<Goodies> goodies = new List<Goodies>()
        {
            new Goodies("Muffin", 180, "SML", "Keto"),
            new Goodies("Cookies", 160, "S", "NonKeto"),
            new Goodies("Burger", 245, "L", "Keto"),
        };

        List<Drinks> drinks = new List<Drinks>()
        {
            new Drinks("Espresso", 145, "SGL", "CoffeeBased"),
            new Drinks("Capuccinno", 165, "DBL", "CoffeeBased"),
            new Drinks("Americano", 175, "L", "CoffeeBased"),
            new Drinks("HotDoubleChocolate", 185, "L", "CoffeeFree"),

        };

        Customer customer;
        public void Run()
        {
            Console.WriteLine("Welcome to Jays Cafe");
            Console.WriteLine("What Should I Call You? ");

            string CustomersName = Console.ReadLine();
            customer = new Customer(CustomersName);
            bool actionCustomer = false;
            do
            {
                Console.WriteLine("Select Action: ");
                Console.WriteLine("1. Buy Goodies");
                Console.WriteLine("2. Buy Drinks");
                Console.WriteLine("3. Checkout");
                string action = Console.ReadLine();


                switch (action)
                {
                    case "1":
                        BuyGoodies();
                        break;
                    case "2":
                        BuyDrinks();
                        break;
                    case "3":
                        Checkout();
                        break;
                }

                Console.WriteLine("Do you want to Buy Add Another Item? (y/n)");
                string ACTIONCUSTOMER = Console.ReadLine().ToLower();
                if (ACTIONCUSTOMER == "y")
                {
                    actionCustomer = true;
                }
                else
                {
                    Checkout();
                    Console.WriteLine("Thank You!");
                    Console.WriteLine("Comeback Again!");
                    actionCustomer = false;
                }
            } while (actionCustomer);


        }

        public void BuyGoodies()
        {
            Goodies goodToBuy = SelectGoodies();

            if (goodToBuy != null) 
            {
                customer.AddGoodies(goodToBuy);
            }
        }

        public void BuyDrinks()
        {
            Drinks drinkToBuy = SelectDrinks();

            if (drinkToBuy != null)
            {
                customer.AddDrinks(drinkToBuy);
            }
        }

        public void Checkout()
        {
            Console.WriteLine("Do You Want to Checkout (Y/N)");

            string action = Console.ReadLine();

            customer.CalculateTotal();
            if (action == "y")
            {
                Console.WriteLine("Successfully Checkout");
            }
        }

        class Customer
        {
            public string Nickname;
            List<Goodies> Goodies;
            List<Drinks> Drinks;
            public double Total;

            public Customer(string nickname)
            {
                Nickname = nickname;
                Goodies = new List<Goodies>();
                Drinks = new List<Drinks>();
                Total = 0;
            }

            public void AddGoodies(Goodies good)
            {
                Goodies.Add(good);
                Console.WriteLine($"Successfully Added {good.GoodName}");
            }
            public void RemoveGoodies(Goodies good)
            {
                Goodies.Remove(good);
                Console.WriteLine($"Successfully Removed {good.GoodName}");
            }

            public void AddDrinks(Drinks drink)
            {
                Drinks.Add(drink);
                Console.WriteLine($"Successfully Added {drink.DrinkName}");
            }

            public void RemoveDrinks(Drinks drink)
            {
                Drinks.Remove(drink);
                Console.WriteLine($"Successfully Removed {drink.DrinkName}");
            }

            public void CalculateTotal()
            {
                for (int i = 0; i < Goodies.Count; i++)
                {
                    Total += Goodies[i].GoodPrice;
                }

                for (int i = 0; i < Drinks.Count; i++)
                {
                    Total += Drinks[i].DrinkPrice;
                }

                Console.WriteLine($"Your Total is {Total}");
                Console.Write("Payment: ");
                double payment = double.Parse(Console.ReadLine());

                if (payment >= Total)
                {
                    Console.WriteLine($"Your Change is {payment - Total}");
                }

                else
                {
                    Console.WriteLine("Not Enough Payment");
                }
                

            }
        }
        Goodies SelectGoodies()
        {
            Console.WriteLine("Goodies Available: ");
            Console.WriteLine("Item,Price,Size,Variant");
            for (int i = 0;  i < goodies.Count; i++)
            {
                Console.WriteLine($"{i+1} {goodies[i].GoodName}, {goodies[i].GoodPrice}, {goodies[i].GoodSize}, {goodies[i].GoodVariant}");
            }
            int goodOption = int.Parse( Console.ReadLine() );
            if ( goodOption > 0 && goodOption < goodies.Count) 
            { 
                return goodies[goodOption - 1];
            }
            return null;

        }

        Drinks SelectDrinks()
        {
            Console.WriteLine("Drinks Available: ");
            Console.WriteLine("Item \t Price \t Size \t Variant");
            for (int i = 0; i < goodies.Count; i++)
            {
                Console.WriteLine($"{i + 1} {drinks[i].DrinkName} \t {drinks[i].DrinkPrice} \t {drinks[i].DrinkSize} \t {drinks[i].DrinkVariant}");
            }
            int drinkOption = int.Parse(Console.ReadLine());
            if (drinkOption > 0 && drinkOption < drinks.Count)
            {
                return drinks[drinkOption - 1];
            }
            return null;

        }
    }

    class Goodies
    {
        public string GoodName;
        public double GoodPrice;
        public string GoodSize;
        public string GoodVariant;

        public Goodies(string GoodName, double GoodPrice, string GoodSize, string GoodVariant)
        {
            this.GoodName = GoodName;
            this.GoodPrice = GoodPrice;
            this.GoodSize = GoodSize;
            this.GoodVariant = GoodVariant;
        }
    }

    class Drinks
    {
        public string DrinkName;
        public double DrinkPrice;
        public string DrinkSize;
        public string DrinkVariant;

        public Drinks(string DrinkName,double Price, string Size, string Variant)
        {
            this.DrinkName = DrinkName;
            this.DrinkPrice = Price;
            this.DrinkSize = Size;
            this.DrinkVariant = Variant;
        }
    }
}
