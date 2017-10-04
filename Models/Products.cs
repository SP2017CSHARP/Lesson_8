using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start.Models
{
    class Products : IProduct
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }

        public Products(string name, int price, string description, int id)
        {
            Name = name;
            Price = price;
            Description = description;
            ID = id;
        }

        public int ChangePrice(int newPrice)
        {
            this.Price = newPrice;

            return newPrice;
        }

        public int GetPrice()
        {
            return Price;
        }

        public void SetPrice(int value)
        {
            this.Price = value;
        }

        public void ShowInformation()
        {
            Console.WriteLine($"Product Name: {Name} \nPrice: {Price} \nDescription: {Description}");
        }
    }
}
