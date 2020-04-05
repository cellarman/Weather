using System;
using System.Collections.Generic;
using System.Text;

namespace Weather
{
    class Seasons
    {

        //Constructor that takes one argument:


        //lattidu
        // public string fall, winter, spring, summer;
        //public string season;
        //public bool coastal;
        //public bool river;
        public string season;
       

        public Seasons(string aSeason)   //constructor of the class
        {
            season = aSeason;
          
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
