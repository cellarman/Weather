using System;
using System.Collections.Generic;
using System.Text;

namespace Weather
{
    class Region
    {
        //lattidu
           public int latitude;
           public bool coastal;
           public bool river;

        public Region(int aLatitude, bool aCoastal, bool aRiver)   //constructor of the class
        {
            latitude = aLatitude;
            coastal = aCoastal;
            river = aRiver;

        }


    }
}
