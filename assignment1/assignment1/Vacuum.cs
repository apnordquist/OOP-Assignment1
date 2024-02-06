using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Vacuum : Appliance
    {
        private static void Main(string[] args)
        {

            Console.WriteLine(" options:");

            
            Console.WriteLine("0 - Any");
            
            Console.WriteLine("1 - Residential");
            
            Console.WriteLine("2 - Commercial");

            
            Console.WriteLine("Enter grade:");

            
            string gradeInput = Console.ReadLine();

            
            string grade = "";

            
            if (gradeInput == "0")
            {
            
                grade = "Any";
            }
            
            else if (gradeInput == "1")
            {
            
                grade = "Residential";
            }
            
            else if (gradeInput == "2")
            {
            
                grade = "Commercial";
            }
            
            else
            {
                                Console.WriteLine("Invalid option.");

                
                return;
            }

            
            Console.WriteLine("Possible options:");

            
            Console.WriteLine("0 Any");
            
            Console.WriteLine("1  18 Volt");
            
            Console.WriteLine("2  24 Volt");

            
            Console.WriteLine("Enter voltage:");

            
            string voltageInput = Console.ReadLine();
            
            int voltage = 0;

            
            if (voltageInput == "0")
            {
            
                voltage = 0;
            }
            
            else if (voltageInput == "1")
            {
            
                voltage = 18;
            }
           
            else if (voltageInput == "2")
            {
              
                voltage = 24;
            }
          
            else
            {
             
                Console.WriteLine("Invalid option.");

              
                return;
            }

       
            List<Appliance> found = new List<Appliance>();

           
            foreach (Appliance appliance in Appliances)
            {
              
                if (appliance is Vacuum)
                {
                  
                    Vacuum vacuum = (Vacuum)appliance;

                 
                    if (grade == "Any" || (grade == vacuum.Grade && (voltage == 0 || voltage == vacuum.Voltage)))
                    {
                   
                        found.Add(appliance);
                    }
                }
            }

         
            DisplayAppliancesFromList(found, 0);
        }

        private static void DisplayAppliancesFromList(List<Appliance> appliances, int index)
        {
            
        }
    }
}
