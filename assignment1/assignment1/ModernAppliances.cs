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
        private Appliance CreateAppliance(long number, string brand, int quantity, int wattage, string color, double price)
        { Appliance appliance = new Appliance(number, brand, quantity,wattage,color,price); }
        private Dishwasher CreateDishwasher(long number, string brand, int quantity, int wattage, string color, double price, string feature, string soundRating)
        { Dishwasher dishwasher = new Dishwasher(number, brand, quantity, wattage, color, price, feature, soundRating); }
        private Microwave CreateMicrowave(long number, string brand, int quantity, int wattage, string color, double price)
        { Microwave microwave = new Microwave(number, brand, quantity, wattage, color, price); }
        private Refrigerator CreateRefrigerator(long number, string brand, int quantity, int wattage, string color, double price, int doors, int height, int width)
        { Refrigerator refrigerator = new Refrigerator(number, brand, quantity, wattage, color, price, doors, height, width); }
        private Vacuum CreateVacuum(long number, string brand, int quantity, int wattage, string color, double price)
        { Vacuum vacuum = new Vacuum(number, brand, quantity, wattage, color, price); }
        //display methods
        public void DisplayAppliances()
        { }
        public void DisplayMenu()
        {
            Console.WriteLine("Welcome to Modern Appliances!\n" +
                "How may we assist you?\n" +
                "1 - Check out appliance\n" +
                "2 - Find appliances by brand\n" +
                "3 - Display appliances by type\n" +
                "4 - Produce random appliance list\n" +
                "5 - Save & exit\n");
        }
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
        private void ReadAppliances() //create the appliance using the provided text file
        {
            string[] lines = File.ReadAllLines(APPLIANCES_TEXT);
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                string p = parts[0];
                char firstChar = p[0];
                switch ( firstChar ) 
                {
                    case '1':
                        CreateRefrigerator(long.Parse(parts[0]), parts[1], int.Parse(parts[2]), int.Parse(parts[3]), parts[4], double.Parse(parts[5]), bool.Parse(parts[6]), int.Parse(parts[7]), int.Parse(parts[8]), int.Parse(parts[9]));
                    case '2':
                        CreateVacuum();
                    case '3':
                        CreateMicrowave();
                    case '4':
                    case '5':
                        CreateDishwasher();
                    case default:
                        CreateAppliance();

                }
            }
        }
        public void ModernAppliances()
        {

        }
    }
}
