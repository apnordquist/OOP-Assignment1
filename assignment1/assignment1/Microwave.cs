using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Microwave: Appliance
    {
        //fields
        private double _capacity;
        private string _roomType;
        public const string roomKitchen = "K";
        public const string roomWorkSite = "W";
        //properties
        public double Capacity { get; set; }
        public string RoomType { get; set; }
        public string RoomTypeDescription { 
            get
            { 
                if (_roomType == roomKitchen)
                    { return "Kitchen"; } 
                if (_roomType == roomWorkSite)
                    { return "Work Site"; }
                else 
                    { return "Unkown"; }
            }
            }
        //constructor
        public Microwave(long number, string brand, int quantity, int wattage, string color, double price, double capacity, string roomType) : base(number, brand, quantity, wattage, color, price)
        {
            Capacity = capacity;
            RoomType = roomType;
        }
        //methods
        public override string FormatForFile()
        { return $"{Number};{Brand};{Quantity};{Wattage};{Color};{Price};{Capacity};{RoomType};"; }
        public override string ToString()
        {
            return $"Item Number: {Number}\n" +
                $"Brand: {Brand}\n" +
                $"Quantity: {Quantity}\n" +
                $"Wattage: {Wattage}W\n" +
                $"Color: {Color}\n" +
                $"Price: ${Price}\n" +
                $"Capacity: {Capacity}\n" +
                $"Room: {RoomTypeDescription}\n";
        }
    }
}
