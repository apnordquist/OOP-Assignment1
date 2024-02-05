using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
           //return details of all appliances that match
        }
        public override void DisplayMicrowaves()
        {
            
        }
        public override void DisplayRefrigerator()
        {
            
        }
        public override void DisplayVacuums()
        {
            
        }
        public override void Find()
        {
            List<Appliance> brandQuery = new List<Appliance>();
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
            //prompt user to enter a number of appliances
            //return that many random appliances using random comparer
        }
    }
}
