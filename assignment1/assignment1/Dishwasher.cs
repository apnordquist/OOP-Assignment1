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
        const string _SoundRatingModerate = "M";
        const string _SoundRatingQuiet = "Qu";
        const string _SoundRatingQuieter = "Qr";
        const string _SoundRatingQuietest = "Qt";
        //properties
        public string Feature { get; set; }
        public string SoundRating { get; set; }
        public string SoundRatingDisplay { get; set; }
        //constructor
        public Dishwasher(long number, string brand, int quantity, int wattage, string color, double price, bool available, string type, string feature, string soundRating) : base(number, brand, quantity, wattage, color, price, available, type)
        {
            Feature = feature; 
            SoundRating = soundRating;
        }
        //setters
        //getters
        //methods
        public override string FormatForFile()
        { return $";"; }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
