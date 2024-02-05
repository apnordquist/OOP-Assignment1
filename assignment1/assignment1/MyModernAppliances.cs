using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace assignment1
{
    internal class MyModernAppliances : ModernAppliances
    {
        //fields
        //properties
        //constructor
        //methods
        public override void Checkout()
        {
            Console.WriteLine("Please enter the item number of the appliance:\n");
            long selection = long.Parse(Console.ReadLine()); //customer inputs number
            foreach (Appliance appliance in Appliances) 
            { if (selection == appliance.Number) 
                { if (appliance.Quantity > 0) //search to see if available
                    {
                        appliance.Quantity--; //if available decrease quantity by one
                        Console.WriteLine(appliance.ToString()); //display appliance info
                    }
                }
            else { Console.WriteLine("Appliance not available"); } //otherwise, display appliance is not
            }
        }
        public override void DisplayDishwashers()
        {
            //prompt user to enter a field (like sound rating)
            List<Appliance> dishwasherList = new List<Appliance>();
            string searchSound = "";
            Console.WriteLine("Which sound rating:\n" +
                "1 - Moderate\n" +
                "2 - Quiet\n" +
                "3 - Quieter\n" +
                "4 - Quietest\n" +
                "Enter selection:\n");
            int soundSelect = int.Parse(Console.ReadLine());
            switch(soundSelect) 
            {
                case 1:
                    searchSound = "M";
                    break;
                case 2:
                    searchSound = "Qu";
                    break;
                case 3:
                    searchSound = "Qr";
                    break;
                case 4:
                    searchSound = "Qt";
                    break;
                default:
                    Console.WriteLine("Selection not found.");
                    break;
            }
            foreach (Appliance appliance in Appliances) // put dishwasher in list based on criteria
            {
                if (searchSound == ((Dishwasher)appliance).SoundRating)
                {
                    dishwasherList.Add(appliance);
                }
            }
            //return details of all appliances that match
            foreach(Appliance appliance in dishwasherList)
            {
                Console.WriteLine(appliance.ToString() );
            }
        }
        public override void DisplayMicrowaves()
        {
            
        }
        public override void DisplayRefrigerator()
        {
            List<Appliance> refrigeratorList = new List<Appliance>();
            string searchDoors = "";
            Console.WriteLine("How many doors:\n";
            int doorSelect = int.Parse(Console.ReadLine());
            foreach (Appliance appliance in Appliances) // put dishwasher in list based on criteria
            {
                if (doorSelect == ((Refrigerator)appliance).Doors)
                {
                    refrigeratorList.Add(appliance);
                }
            }
            //return details of all appliances that match
            foreach (Appliance appliance in refrigeratorList)
            {
                Console.WriteLine(appliance.ToString());
            }
        }
        public override void DisplayVacuums()
        {
            
        }
        public override void Find()
        {
            List<Appliance> brandQuery = new List<Appliance>(); //new list for the brand quarry
            Console.WriteLine("Please enter the brand you are searching for:\n");
            string query = Console.ReadLine(); //prompt user to enter a brand
            foreach (Appliance appliance in Appliances)
            {
                if (query == appliance.Brand)
                {
                    brandQuery.Add(appliance);
                }
            }
            foreach (Appliance appliance in brandQuery)//return matching appliances in a new list
            {
                Console.WriteLine(appliance.ToString);
            }
        }
        public override void RandomList()
        {
            List<Appliance> randomAppliances = new List<Appliance>(); //new list for the random selection
            //prompt user to enter type of appliances
            Console.WriteLine("Appliance Types:\n" +
                "1 - Refirgerators\n" +
                "2 - Vacuums\n" +
                "3 - Microwaves\n" +
                "4 - Dishwashers\n" +
                "Enter type of type of appliance:\n");
            char selectionRandom = char.Parse(Console.ReadLine());
            //prompt user to enter a number of appliances
            Console.WriteLine("How many appliances:\n");
            int numberRandom = int.Parse(Console.ReadLine());
            //return that many random appliances using random comparer
            for (int i = 0; i < numberRandom; i++) //where to add randomcomaparer?
            {
                foreach (Appliance appliance in Appliances)
                {
                    if (selectionRandom == appliance.Number[0];
                    {
                        randomAppliances.Add(appliance);
                    }
                }
            }
            foreach (Appliance appliance in randomAppliances)
            {
                Console.WriteLine(appliance.ToString);
            }
        }
    }
}
