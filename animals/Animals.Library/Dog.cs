using System;

namespace Animals.Library
{
    public class Dog 
    {
        //fields
        public string noise = "Woof!";

        public string getNoise()
        {
            return noise;
        }

        public void setNoise(string newNoise)
        {
            if(newNoise.Length < 1 || newNoise == null)
            {
                throw new ArgumentException("value must not be null or empty");
            }
            noise = newNoise;
        }

        private string _name;
        public string Name 
        { 
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Color { get; } = "brown";


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