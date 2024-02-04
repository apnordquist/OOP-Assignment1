using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class  RandomComparer : IComparer<Appliance>
    {
        //fields
        private Random _random = new Random();
        //methods
        public int Compare(Appliance x, Appliance y)
        {
            if (x == y)
            {
                return 0;
            }
        }
    }
}
