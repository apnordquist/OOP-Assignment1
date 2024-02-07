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
        public const string SoundRatingModerate = "M";
        public const string SoundRatingQuiet = "Qu";
        public const string SoundRatingQuieter = "Qr";
        public const string SoundRatingQuietest = "Qt";
        //properties
        public string Feature { get; set; }
        public string SoundRating { get; set; }
        public string SoundRatingDisplay
        {
            get
            {
                switch (SoundRating) //find display based on constant
                {
                    case SoundRatingModerate:
                        return "Moderate";
                        break;
                    case SoundRatingQuiet:
                        return "Quiet";
                        break;
                    case SoundRatingQuieter:
                        return "Queiter";
                        break;
                    case SoundRatingQuietest:
                        return "Quietest";
                        break;
                    default:
                        return "Unkown";
                        break;
                }
            }
        }
        //constructor
        public Dishwasher(long number, string brand, int quantity, int wattage, string color, double price, string feature, string soundRating) : base(number, brand, quantity, wattage, color, price)
        {
            Feature = feature; 
            SoundRating = soundRating;
        }
        //methods
        public override string FormatForFile()
        { return $";"; }
        public override string ToString()
        {
            return $"Item Number: {Number}\n" +
                $"Brand: {Brand}\n" +
                $"Quantity: {Quantity}\n" +
                $"Wattage: {Wattage}W\n" +
                $"Color: {Color}\n" +
                $"Price: ${Price}\n" +
                $"Features: {Feature}\n" +
                $"Sound Rating: {SoundRatingDisplay}\n";
        }
    }
}
