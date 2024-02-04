using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Dishwasher: Appliance
    {
        //fields
        private string _feature;
        private string _soundRating;
        //properties
        public string Number { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int Wattage { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public string IsAvailable { get; set; }
        public string Type { get; set; }
        public string Feature { get; set; }
        public string SoundRating { get; set; }
        //constructor
        //setters
        //getters
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
