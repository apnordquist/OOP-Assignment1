using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    //this class is to support each individual type of appliance and their related methods
    abstract class Appliance
    {
        //fields
        private string _brand;
        private string _color;
        private long _number;
        private double _price;
        private int _quantity;
        private int _wattage;
        //properties
        public long Number { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int Wattage { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public bool IsAvailable
        {
            get
            {
                if (_quantity > 0)
                { return true; }
                else
                { return false; }
            }
        }
        public string Type 
        { 
            get
            { 
                string itemString = _number.ToString();
                char firstChar = itemString[0];
                switch (firstChar)
                {
                    case '1':
                        return "Refrigerator";
                        break;
                    case '2':
                        return "Vacuum";
                        break;
                    case '3':
                        return "Microwave";
                        break;
                    case '4':
                    case '5':
                        return "Dishwasher";
                        break;
                    default:
                        return "Unknown";
                        break;
                } 
            }
        }
        //default constructor
        public Appliance(long number, string brand, int quantity, int wattage, string color, double price) 
        {
            Number = number;
            Brand = brand;
            Quantity = quantity;
            Wattage = wattage;
            Color = color;
            Price = price;
        }
        //methods
        public void Checkout()
        {
            _quantity -= 1; //place holder until I figure it out
/*            List<Appliance> AppList = new List<Appliance>();
            Console.WriteLine("Enter the item number of an appliance:\n");
            string AppCheck = Console.ReadLine(); //customer inputs item number
            if (AppCheck in AppList) //check appliance availablity
            {
                if (App.IsAvailable = True)
                {
                    Appliance.Quantity -= 1; //if availble, decrease quantity
                    return "";             //display information
                }
            }
            else
            {
                Console.WriteLine("Item number was not found.");
            }*/
        }
        public string DetermineBrand()
        { return Brand; }
        public abstract string FormatForFile();
    }
}
