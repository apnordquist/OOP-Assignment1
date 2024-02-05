using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Refrigerator : Appliance
    {
        //fields
        private int _doors;
        private int _height;
        private int _width;
        //properties
        public int Doors { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        //constructor
        public Refrigerator(long number, string brand, int quantity, int wattage, string color, double price, int doors, int height, int width) : base(number, brand, quantity, wattage, color, price)
        {
            Doors = doors;
            Height = height;
            Width = width;
        }
        //getters
        //setters
        //methods
        public override string FormatForFile()
        { return $"{Number};{Brand};{Quantity};{Wattage};{Color};{Price};{Doors};{Height};{Width};"; }
        public override string ToString()
        {
            return $"Item Number: {Number}\nBrand: {Brand}\nQuantity: {Quantity}\nWattage: {Wattage}W\nColor: {Color}\nPrice: ${Price}\nNumber of doors: {Doors}\nHeight: {Height} inches\nWidth: {Width}inches";
        }
    }
}
