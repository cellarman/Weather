using System;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            
            // Call the constructor that has one parameter.
         //   Season fall = new Season();
            


          //  Console.WriteLine(Season.Fall);


            //create region objects
            Region seattle = new Region(47,true, false );
            Region portland = new Region(45,true, true);
            Region charlotte = new Region(35, false, false);

            Console.WriteLine(seattle.latitude);
            Console.WriteLine(seattle.coastal);
            Console.WriteLine(portland.coastal);


            //create seasons objects
            Seasons fall = new Seasons("fall");
            Seasons spring = new Seasons("spring");
            Seasons summer = new Seasons("summer");
            Seasons winter = new Seasons("winter");


            // Seasons Winter = new Seasons();

            //Seasons Spring = new Seasons();

            //  Seasons Summer = new Seasons();
            //ca










        }





    }
}
