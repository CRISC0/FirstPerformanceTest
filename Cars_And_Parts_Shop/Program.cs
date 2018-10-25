using System;
using System.Collections.Generic;

namespace Cars_And_Parts_Shop
{
    class Program
    {
        public static List<Car_Full_Stock> car_stock = new List<Car_Full_Stock>();
        public static List<Accessory> accessories = new List<Accessory>();
        public static List<Brand> brand = new List<Brand>();

        static void Main(string[] args)
        {
            Console.Clear();

            int option = 0;
            while (option == 0)
            {
                try
                {
                    Console.Clear();
                    Screen.ShowScreen();
                    option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Screen.CarRegister();
                            Console.WriteLine("All Registered.");
                            Console.Write("Press 'ENTER' to continue");

                            try
                            {
                                option = int.Parse(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Internal Error " + e.Message);
                                option = 0;
                            }
                            break;

                        case 2:
                            Screen.AccessoryRegister();
                            Console.WriteLine("All Registered.");
                            Console.Write("Press 'ENTER' to continue");

                            try
                            {
                                option = int.Parse(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Internal Error " + e.Message);
                                option = 0;
                            }
                            break;

                        case 3:
                            Screen.BrandRegister();
                            Console.WriteLine("All Registered.");
                            Console.Write("Press 'ENTER' to continue");

                            try
                            {
                                option = int.Parse(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Interna, Error " + e.Message);
                                option = 0;
                            }
                            break;

                        case 4:
                            Screen.ShowCarWAccessoriesDetails();
                            Console.Write("Press 'ENTER' to continue");

                            try
                            {
                                option = int.Parse(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Internal Error " + e.Message);
                                option = 0;
                            }
                            break;

                        case 5:
                            Screen.ShowAccessoryDetails(); 
                            Console.Write("Press 'ENTER' to continue");

                            try
                            {
                                option = int.Parse(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Internal Error " + e.Message);
                                option = 0;
                            }
                            break;

                        case 6:
                            Screen.ShowBrands();
                            Console.Write("Press 'ENTER' to continue");

                            try
                            {
                                option = int.Parse(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Internal Error " + e.Message);
                                option = 0;
                            }
                            break;

                        case 7:
                            Screen.RealFinalPrice();
                            Console.WriteLine("Press 'ENTER' to continue.");

                            try
                            {
                                option = int.Parse(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Internal Error " + e.Message);
                                option = 0;
                            }
                            break;

                        case 8:
                            Console.WriteLine("Ending...");
                            break;

                        default:
                            Console.WriteLine("Option not found, please select a valid option");
                            option = 0;
                            Console.ReadLine();
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Option not found, please select a valid option");
                    option = 0;
                    Console.ReadLine();
                }
            }
        }
    }
}