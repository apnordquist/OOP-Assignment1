using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    abstract class Appliance
    {
        //fields
        private string _brand;
        private string _color;
        private string _number;
        private double _price;
        private int _quantity;
        private int _wattage;
        //properties
        public string Number { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int Wattage { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public string IsAvailable { get; set; }
        public string Type { get; set; }

        //methods
        //public abstract void Appliance();
        public abstract void Checkout();
        public abstract string DetermineBrand();
        public abstract string FormatForFile();
    }
}
