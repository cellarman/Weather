using System;
using System.Collections.Generic;
using System.Text;

namespace Weather
{
    class Season
    {

        //Constructor that takes one argument:
        public Season(string seasonType)
        {
            seasonType = seasonType;
        }



        public void Rain()
        {
            Console.WriteLine("It is raining");
        }

        public void Wind()
        {
            Console.WriteLine("It is windy");
        }

        public void Snow()
        {
            Console.WriteLine("It is snowing");
        }

        public void Dry()
        {
            Console.WriteLine("It is dry");
        }



    }
}
