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
        //methods
        public override string FormatForFile()
        { return $"{Number};{Brand};{Quantity};{Wattage};{Color};{Price};{Doors};{Height};{Width};"; }
        public override string ToString()
        {
            return $"Item Number: {Number}\n" +
                $"Brand: {Brand}\n" +
                $"Quantity: {Quantity}\n" +
                $"Wattage: {Wattage}W\n" +
                $"Color: {Color}\n" +
                $"Price: ${Price}\n" +
                $"Number of doors: {Doors}\n" +
                $"Height: {Height} inches\n" +
                $"Width: {Width} inches";
        }
    }
}
