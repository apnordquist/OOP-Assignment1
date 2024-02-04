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
        public string Number { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int Wattage { get; set; }
        public string Color {  get; set; }
        public double Price { get; set; }
        public int Doors { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        //constructor
        public Refrigerator()
        { }
        //getters
        //setters
        //methods
        public override void Checkout()
        { }
        public override string DetermineBrand()
        { return Brand; }
        public override string FormatForFile()
        { return $";"; }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
