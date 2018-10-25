using System;
using System.Collections.Generic;
using System.Text;

namespace Cars_And_Parts_Shop
{
    class Brand
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public Brand(int Code, string Name, string Country)
        {
            this.Name = Name;
            this.Code = Code;
            this.Country = Country;
        }

        public override string ToString()
        {
            return 
                Name
                + ", Code: "
                + Code
                + ", Country: "
                + Country;
        }
    }
}