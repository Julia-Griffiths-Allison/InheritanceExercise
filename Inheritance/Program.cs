using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird Parrot = new Bird()
            {
                Breathing = "alive and breathing",
                Order = "Psittaciformes",
                Tail = "feathered tail",
                Longevity = "20-70 years",
                Colors = "bright red, green, blue, yellow colors",
                Name = "Parrots",
                Diet = "fruits and veggies",
                Size = "2 - 3.5 feet"
            };

            Console.WriteLine($"{ Parrot.Name} are {Parrot.Breathing}. Their technical order is {Parrot.Order} and they live about {Parrot.Longevity}. Some {Parrot.Name}s have {Parrot.Colors} with {Parrot.Tail}, they eat {Parrot.Diet} and are about {Parrot.Size}.");
            Console.WriteLine("");
            Reptile Python = new Reptile()
            {
                Breathing = "alive and breathing",
                Order = "Squanata",
                Tail = "Not sure where the tail starts, but it has one",
                Longevity = "roughly 30 year maximum",
                Name = "Ball Python",
                Colors = "variety, although they're normally brown and black",
                Size = "around 5' long",
                Diet = "captive pets will normally eat dead mice, or other small rodents"
            };

            Console.WriteLine($"{Python.Name} are {Python.Breathing}. Their technical order is {Python.Order} and they live about {Python.Longevity}. Some {Python.Name}s have a {Python.Colors} of colors, they eat {Python.Diet} and are about {Python.Size}. {Python.Tail}.");


            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
