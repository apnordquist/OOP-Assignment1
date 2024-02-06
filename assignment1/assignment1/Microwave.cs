using System;
using System.Collections.Generic;

namespace assignment1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Options");
            Console.WriteLine("0 Any");
            Console.WriteLine("1  Kitchen");
            Console.WriteLine("2 Work site");
            Console.WriteLine("Enter the room type:");

            string userInput = Console.ReadLine();
            char roomType;

            if (userInput == "0")
            {
                
                roomType = 'A';
            }
            
            else if (userInput == "1")
            {
                
                roomType = 'K';
            }
        
            else if (userInput == "2")
            {
                
                roomType = 'W';
            }
            
            else
            {
            
                Console.WriteLine("Invalid option.");
                
                return;
            }

           
            List<Appliance> found = new List<Appliance>();

         
            foreach (Appliance appliance in Appliances)
            {
          
                if (appliance is Microwave)
                {
              
                    Microwave microwave = (Microwave)appliance;

              
                    if (roomType == 'A' || microwave.RoomType == roomType)
                    {
                      
                        found.Add(appliance);
                    }
                }
            }

   
            DisplayAppliancesFromList(found, 0);
        }


        static void DisplayAppliancesFromList(List<Appliance> appliances, int index)
        {

        }
    }

    internal class Appliance
    {
      
    }

    internal class Microwave : Appliance
    {
        public char RoomType { get; set; }
  
    }
}
