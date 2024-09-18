using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders
{
    public class Cars
    {
        public string Make { get; set; }

        public string Model { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CarsAdded { get; set; }

        public Cars(string make, string model, decimal price, int stock)
        {
            Make = make;
            Model = model;
            Price = price;
            Stock = stock;

        }
    }
}
