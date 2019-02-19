using System;
using System.Collections.Generic;
using System.Text;

namespace MoreAnimals.Library
{
    public class Eagle : ABird
    {
        //implementation of abstract method
        public override void MakeNoise()
        {
            Console.WriteLine("Screech!");
        }

        //method is hidden and will not run because ABird method supercedes it, must override explicitely
        public void GoTo(string location)
        {
            Console.WriteLine($"I'm an eagle flying to {location}");
        }
    }
}
