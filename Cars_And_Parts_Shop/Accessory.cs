using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Cars_And_Parts_Shop
{
    class Accessory
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Code { get; set; }

        public Accessory(string Name, double Price, int Code)
        {
            this.Name = Name;
            this.Price = Price;
            this.Code = Code;
        }

        public override string ToString()
        {
            return 
                Name
                + ", Price: $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Code: "
                + Code;
        }
    }
}