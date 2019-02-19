using System;
using MoreAnimals.Library;

namespace MoreAnimals.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var fido = new Dog()
            {
                Id = 1,
                Name = "Fido",
                Breed = "Pug"
            };

            fido.GoTo("Park");
            fido.MakeNoise();

            //IAnmial is parent type of Dog.
            //Dog is subtype of IAnimal

            var animals = new IAnimal[2];
            animals[0] = fido;
            animals[1] = new Eagle()
            {
                Id = 2,
                Name = "Chirpy"
            };

            foreach(var Item in animals)
            {
                Console.WriteLine(Item.Name);
                Item.MakeNoise();
            }

        }

        //a class can implement as many interfaces as needed but can only have one parent class
    }
}
