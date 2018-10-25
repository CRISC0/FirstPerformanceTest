using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Cars_And_Parts_Shop
{
    class Screen
    {
        public static void ShowScreen()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("--------------Nameless Store-----------------");
            Console.WriteLine("-----------Cars and Auto-Parts---------------");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("1 - Register a Car");
            Console.WriteLine("2 - Register a Accessory");
            Console.WriteLine("3 - Register a Brand");
            Console.WriteLine("4 - Show All Cars Registered");
            Console.WriteLine("5 - Show All Accessories Registered");
            Console.WriteLine("6 - Show All Brands Registered");
            Console.WriteLine("7 - Calculate Prices");
            Console.WriteLine("8 - Exit");
            Console.WriteLine("---------------------------------------------");
            Console.Write("Your Choice: ");
        }

        public static void CarRegister()
        {
            Console.WriteLine("Register a Car.");
            Console.Write("Type the Amount of cars that will be registered: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Type the " + i + "º Car Information: ");
                Console.Write("Car Code: ");
                int Code = int.Parse(Console.ReadLine());
                Console.Write("Model: ");
                string Model = Console.ReadLine();
                Console.Write("Year: ");
                int Year = int.Parse(Console.ReadLine());
                Console.Write("Initial Price: $");
                double BasePrice = double.Parse(Console.ReadLine());
                Car_Full_Stock CF = new Car_Full_Stock(Code, Model, Year, BasePrice);
                Program.car_stock.Add(CF);
            }
        }

        public static void BrandRegister()
        {
            Console.WriteLine("Register a Brand.");
            Console.Write("Type the Amount of Brands that will be registered: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                int Code = 0;
                string Name = null;
                string Country = null;
                Console.WriteLine("Type the Information of the " + i + "º Brand:");
                Console.Write("Brand's Code: ");
                try
                {
                    Code = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Fatal Error - Wrong Value " + e.Message);
                }
                Console.Write("Name: ");
                try
                {
                    Name = Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Fatal Error - Wrong value " + e.Message);
                }
                Console.Write("Country: ");
                try
                {
                    Country = Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Fatal Error - Wrong value " + e.Message);
                }
                Brand B = new Brand(Code, Name, Country);
                Program.brand.Add(B);
            }
        }

        public static void AccessoryRegister()
        {
            Console.WriteLine("Register a Accessory.");
            try
            {
                Console.Write("Type the Amount of Accessories that will be Registered: ");
                int N = int.Parse(Console.ReadLine());
                for (int i = 1; i <= N; i++)
                {
                    int Code = 0;
                    string Name = null;
                    double Price = 0.0;
                    Console.WriteLine("Type the Information of the " + i + "º Accessory: ");
                    Console.Write("Name: ");
                    try
                    {
                        Name = Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Fatal Error - Wrong Value " + e.Message);
                    }
                    Console.Write("Price: $");
                    try
                    {
                        Price = double.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Fatal Error - Wrong Value " + e.Message);
                    }
                    Console.Write("Code: ");
                    try
                    {
                        Code = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Fatal Error - Wrong Valor " + e.Message);
                    }
                    Accessory A = new Accessory(Name, Price, Code);
                    Program.accessories.Add(A);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Fatal Error - Many arguments are wrong. " + e.Message);
            }
        }

        public static void ShowAccessoryDetails()
        {
            Console.WriteLine("Accessory Information: ");
            var Amount = 0;
            foreach (var accessory in Program.accessories)
            {
                Amount++;
                Console.WriteLine(Amount + "º " + accessory);
            }
        }

        public static void ShowBrands()
        {
            Console.WriteLine("Brands Information: ");
            var Amount = 0;
            foreach (var brand in Program.brand)
            {
                Amount++;
                Console.WriteLine(Amount + "º " + brand);
            }
        }

        public static void ShowCarWAccessoriesDetails()
        {
            Console.WriteLine("Car Information: ");
            var Amount = 0;
            foreach (var car_stock in Program.car_stock)
            {
                Amount++;
                Console.WriteLine(Amount + "º " + car_stock);
            }
        }

        public static void RealFinalPrice()
        {
            Console.Write("Car Price: $");
            double PriceCar = double.Parse(Console.ReadLine());
            Console.Write("Accessory Price: $");
            double PriceAccessory = 0.0;
            try
            {
                PriceAccessory = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Fatal Error - Invalid Value " + e.Message);
            }
            Console.Write("Add Another Accessory? [S/N] ");
            string resp = Console.ReadLine();
            double ExtraAccessory = 0.0;
            if (resp == "s")
            {
                Console.Write("Accessory Price: $");
                try
                {
                    ExtraAccessory = double.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Fatal Error - Invalid Value " + e.Message);
                }
            }

            Program.accessories.FindIndex(x => x.Price == PriceAccessory);
            Program.accessories.FindIndex(x => x.Price == ExtraAccessory);
            Program.car_stock.FindIndex(x => x.BasePrice == PriceCar);

            double Total()
            {
                double FinalPrice = PriceCar + PriceAccessory + ExtraAccessory;
                return FinalPrice;
            }

            Console.WriteLine("Final Price: $" + Total());
        }
    }
}