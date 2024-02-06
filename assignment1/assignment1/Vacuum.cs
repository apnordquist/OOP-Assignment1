using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Vacuum : Appliance
    {
        //fields
        private string _batteryVoltage;
        private string _grade;
        //properties
        public string BatteryVoltage { get; set; }
        public string Grade { get; set; }
        //constructor
        public Vacuum(long number, string brand, int quantity, int wattage, string color, double price, string grade, string voltage) : base(number, brand, quantity, wattage, color, price)
        {
            Grade = grade;
            BatteryVoltage = voltage;
        }
        //methods
        public override string FormatForFile()
        { return $"{Number};{Brand};{Quantity};{Wattage};{Color};{Price};{BatteryVoltage};{Grade};"; }
        public override string ToString()
        {
            return $"Item Number: {Number}\n" +
                $"Brand: {Brand}\n" +
                $"Quantity: {Quantity}\n" +
                $"Wattage: {Wattage}W\n" +
                $"Color: {Color}\n" +
                $"Price: ${Price}\n" +
                $"Voltage: {BatteryVoltage}\n" +
                $"Grade: {Grade}\n";
        }
    }
}
