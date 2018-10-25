using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Cars_And_Parts_Shop
{
    class Car_Full_Stock
    {
        public int Code { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double BasePrice { get; set; }
        public static List<Car_Full_Stock> car_stock = new List<Car_Full_Stock>();

        public Car_Full_Stock(int Code, string Model, int Year, double BasePrice)
        {
            this.Code = Code;
            this.Model = Model;
            this.Year = Year;
            this.BasePrice = BasePrice;
            car_stock = new List<Car_Full_Stock>();
        }

        public double Price()
        {
            double sum = 0;
            for (int i = 0; i < car_stock.Count; i++)
            {
                sum = sum + car_stock[i].BasePrice;
            }
            return sum;
        }

        public override string ToString()
        {
            return "Code: "
                + Code + "\n"
                + "   Model: "
                + Model + "\n"
                + "   Year: "
                + Year + "\n"
                + "   Base Price: $"
                + BasePrice.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}