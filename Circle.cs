using System;
using System.Collections.Generic;
using System.Text;

namespace Circle
{
    class Circle
    {
        float Pi = 3.141f;
        public int Radius;
        public int circum;
        public void getarea()
        {
            Console.WriteLine("Radien på cirkeln är " + Radius*Radius+Pi);
        }
        public void getcircum()
        {
            Console.WriteLine("Omkretsen på circeln är " + 2 * Pi * Radius);
        }
     
    }
}
