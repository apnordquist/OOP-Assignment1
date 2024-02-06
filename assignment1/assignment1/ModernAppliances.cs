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
        public ModernAppliances()
        {
            appliances = ReadAppliances();
        }
        //methods
        public abstract void Checkout();
        //create new appliances by class
        //private Appliance CreateAppliance(long number, string brand, int quantity, int wattage, string color, double price) 
        //{ Appliance appliance = new Appliance(number, brand, quantity, wattage, color, price); }
        //unsure why needed since it is an abstract class but is listed in the example
        private Dishwasher CreateDishwasher(long number, string brand, int quantity, int wattage, string color, double price, string feature, string soundRating)
        { return new Dishwasher(number, brand, quantity, wattage, color, price, feature, soundRating); }
        private Microwave CreateMicrowave(long number, string brand, int quantity, int wattage, string color, double price, double capacity, string roomType)
        { return new Microwave(number, brand, quantity, wattage, color, price, capacity, roomType); }
        private Refrigerator CreateRefrigerator(long number, string brand, int quantity, int wattage, string color, double price, int doors, int height, int width)
        { return new Refrigerator(number, brand, quantity, wattage, color, price, doors, height, width); }
        private Vacuum CreateVacuum(long number, string brand, int quantity, int wattage, string color, double price, string grade, string voltage)
        { return new Vacuum(number, brand, quantity, wattage, color, price, grade, voltage); }
        //display methods
        public void DisplayAppliances()
        { 
            foreach (Appliance appliance in Appliances)
            {
                Console.WriteLine(appliance.ToString() + "\n");//double check formatting, should be pull each method by type?
            }
        }
        public void DisplayMenu() //use this as part of other functions
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
        {
            Console.WriteLine("Appliance Types:\n" +
                "1 - Refirgerators\n" +
                "2 - Vacuums\n" +
                "3 - Microwaves\n" +
                "4 - Dishwashers\n" +
                "Enter type of type of appliance:\n");
            char Selection = char.Parse(Console.ReadLine());
            switch (Selection) //need to create each display method to test this
            {
                case '1':
                    DisplayRefrigerator();
                    break;
                case '2':
                    DisplayVacuums();
                    break;
                case '3':
                    DisplayMicrowaves();
                    break;
                case '4':
                    DisplayDishwashers();
                    break;
                default:
                    Console.WriteLine("Selection not found.");
                    break;
            }
        }
        public abstract void DisplayDishwashers();
        public abstract void DisplayMicrowaves();
        public abstract void DisplayRefrigerator();
        public abstract void DisplayVacuums();
        //other methods
        public abstract void Find();
        public abstract void RandomList();
        private List<Appliance> ReadAppliances() //create the appliance using the provided text file
        {
            List<Appliance> Appliances = new List<Appliance>();
            string[] lines = File.ReadAllLines(APPLIANCES_TEXT);
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                string p = parts[0];
                char firstChar = p[0];
                switch ( firstChar ) 
                {
                    case '1':
                        appliances.Add(CreateRefrigerator(long.Parse(parts[0]), parts[1], int.Parse(parts[2]), int.Parse(parts[3]), parts[4], double.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]), int.Parse(parts[8])));
                        break;
                    case '2':
                        appliances.Add(CreateVacuum(long.Parse(parts[0]), parts[1], int.Parse(parts[2]), int.Parse(parts[3]), parts[4], double.Parse(parts[5]), parts[6], parts[7]));
                        break;
                    case '3':
                        appliances.Add(CreateMicrowave(long.Parse(parts[0]), parts[1], int.Parse(parts[2]), int.Parse(parts[3]), parts[4], double.Parse(parts[5]), double.Parse(parts[6]), parts[7]));
                        break;
                    case '4':
                    case '5':
                        appliances.Add(CreateDishwasher(long.Parse(parts[0]), parts[1], int.Parse(parts[2]), int.Parse(parts[3]), parts[4], double.Parse(parts[5]), parts[6], parts[7]));
                        break;
                }
            }
            return Appliances;
        }
        public void Save() //save the updated text file
        {
            StreamWriter fileStream = File.CreateText(APPLIANCES_TEXT);

            foreach (Appliance appliance in Appliances)
            {
                fileStream.WriteLine(appliance.FormatForFile());
            }

            fileStream.Close();

            Console.WriteLine("File saved.");
        }
    }
}
