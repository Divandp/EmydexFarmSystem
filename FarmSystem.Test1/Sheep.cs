using System;

namespace FarmSystem.Test1
{
    public class Sheep : Animal
    {
        public Sheep(string id, int noOfLegs) : base(id, noOfLegs)
        {
        }

        public override void Talk()
        {
            Console.WriteLine("Sheep says baa!");
        }

        public override void Run()
        {
            Console.WriteLine("Sheep is running");
        }
    }

}