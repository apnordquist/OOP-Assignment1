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
        public bool IsAvailable { get; set; }
        public string Type { get; set; }
        //default constructor
        public Appliance(long number, string brand, int quantity, int wattage, string color, double price, bool available, string type) 
        {
            Number = number;
            Brand = brand;
            Quantity = quantity;
            Wattage = wattage;
            Color = color;
            Price = price;
            IsAvailable = available;
            Type = type;
        }
        //methods
        public void Checkout()
        {
            _quantity -= 1;
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
