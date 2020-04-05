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
            Region portland = new Region(45,true, true );
            Region charlotte = new Region(35, false, true);

            Console.WriteLine(seattle.latitude);
            Console.WriteLine(seattle.coastal);


            //ca










        }





    }
}
