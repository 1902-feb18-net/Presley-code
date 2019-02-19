using System;

namespace Animals.UI
{
    public class Dog 
    {
        //fields
        public string noise = "Woof!";

        //methods
        public void GoTo(string location)
        {
            //simple string concat
            Console.WriteLine("Walking to " + location);

            //fancy way
            Console.WriteLine($"Walking to {location}");
        }

        public void MakeNoise()
        {
            Console.WriteLine(noise);
        }
    }
}