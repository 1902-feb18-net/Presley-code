using System;
using System.Collections.Generic;
using System.Text;

namespace MoreAnimals.Library
{
    //an abstract class is like a mix b/t class and interface, implement some and leave others unimplemented
    public abstract class ABird : IAnimal
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void GoTo(string location)
        {
            Console.WriteLine($"Flying to {location.ToLower()}");
        }
        //sublcasses of ABird would need to implement this method
        public abstract void MakeNoise();
        
    }
}
