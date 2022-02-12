using System;
using FarmSystem.Test2;

namespace FarmSystem.Test1
{
    // Inherits from animals
    public class Cow : Animal, IMilkableAnimal
    {
        public Cow(string id, int noOfLegs) : base(id, noOfLegs)
        {
        }

        public override void Talk()
        {
            Console.WriteLine("Cow says Moo!");
        }


        public void Walk()
        {
            Console.WriteLine("Cow is walking");
        }

        public void ProduceMilk()
        {
            Console.WriteLine("Cow was milked!");
        }

        public override void Run()
        {
            Console.WriteLine("Cow is running");
        }

    }
}