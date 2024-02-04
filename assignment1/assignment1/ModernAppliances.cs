using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    //this class is for the operation of the business "Modern Appliances" through various methods that handle Appliance objects
    abstract class ModernAppliances
    {
        //fields
        private List<Appliance> appliances;
        const string APPLIANCES_TEXT = "appliances.txt"; //default file
        //properties
        public List<Appliance> Appliances { get; set; }
        //constructor
        //methods
        public abstract void Checkout();
        //create new appliances by class
        private Appliance CreateAppliance()
        { Appliance appliance = new Appliance(); }
        private Dishwasher CreateDishwasher()
        { Dishwasher dishwasher = new Dishwasher(); }
        private Microwave CreateMicrowave()
        { Microwave microwave = new Microwave(); }
        private Refrigerator CreateRefrigerator()
        { Refrigerator refrigerator = new Refrigerator(); }
        private Vacuum CreateVacuum()
        { Vacuum vacuum = new Vacuum(); }
        //display methods
        public void DisplayAppliances()
        {}
        public void DisplayMenu()
        { }
        public void DisplayType()
        { }
        public abstract void DisplayDishwashers();
        public abstract void DisplayMicrowaves();
        public abstract void DisplayRefrigerator();
        public abstract void DisplayVacuum();
        //other methods
        public abstract void Find();
        public abstract void RandomList();
        public void Save()
        {

        }
        private void ReadAppliances()
        {

        }
        public void ModernAppliances()
        {

        }
    }
}
