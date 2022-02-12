using System;
using System.Collections.Generic;
using System.Linq;
using FarmSystem.Test2;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        //This is an queue that uses first in first out.
        private Queue<Animal> _farmQueue;
        public EmydexFarmSystem()
        {
            _farmQueue = new Queue<Animal>();
        }
        
        //TEST 1

        /// <summary>
        /// Load an animal into the farm
        /// </summary>
        /// <param name="animal">The animal to load</param>
        public void Enter(Animal animal)
        {
            //Add the animal to the queue 
            _farmQueue.Enqueue(animal);
            DisplayAnimal(animal);
        }

        /// <summary>
        /// Displays all the animals in the farm
        /// </summary>
        private void DisplayAnimalsInFarm()
        {
            foreach (var animal in _farmQueue)
            {

                DisplayAnimal(animal);

            }
        }

        /// <summary>
        ///      Displays an animal that has entered the farm
        /// </summary>
        /// <param name="animal">The animal that needs to be displayed</param>
        private static void DisplayAnimal(Animal animal)
        {
            var animalName = animal.GetType().Name;
            Console.WriteLine($"{animalName} has entered the farm");
        }


        /// <summary>
        ///     Release an animal from the farm. Prints the release of the animal. 
        /// </summary>
        /// <param name="animal">The animal to release </param>
        private static void ReleaseAnimal(Animal animal)
        {
            var animalName = animal.GetType().Name;
            Console.WriteLine($"{animalName} has left the farm");
        }

        //TEST 2

        /// <summary>
        ///     Make all the animals in the queue make noise.
        /// </summary>
        public void MakeNoise()
        {
            //Display all the animals in the farm.
            DisplayAnimalsInFarm();
            foreach (var animal in _farmQueue)
            {
                MakeAnimalTalk(animal);
            }
        }

        /// <summary>
        ///     Makes the animal talk.
        /// </summary>
        /// <param name="animal">The animal to make talk.</param>
        private void MakeAnimalTalk(Animal animal)
        {
            animal.Talk();
        }

        //TEST 3

        /// <summary>
        ///     Milk all the animals that can be milked.
        /// </summary>
        public void MilkAnimals()
        {
            //Show all the animals in the farm.
            DisplayAnimalsInFarm();
            foreach (var animal in _farmQueue)
            {
                //Check if an animal in the farm can be milked if it can we milk it. 
                if (animal is IMilkableAnimal milkAbleAnimal)
                {
                    //Milk the animal
                    milkAbleAnimal.ProduceMilk();
                }

            }

        }

        //TEST 4

        /// <summary>
        ///     Release all the animals in the farm.
        /// </summary>
        public void ReleaseAllAnimals()
        {

            //While there are animals in the queue we release them on a first in first out method
            while (_farmQueue.Any())
            {
                ReleaseAnimal(_farmQueue.Dequeue());
            }
            //When the farm is empty we raise an event
            if(!_farmQueue.Any())
                OnFarmEmpty();

        }
        //Define the delegate
        public delegate void FarmEmptyEventHandler(object source, EventArgs args);

        //Define an event based on the delegate
        public event FarmEmptyEventHandler FarmEmpty;

        protected virtual void OnFarmEmpty()
        {
            if(FarmEmpty != null)
                FarmEmpty(this,EventArgs.Empty);
        }

        public void OnFarmEmpty(object source, EventArgs e)
        {
            Console.WriteLine("Emydex Farm is now empty");
        }
}
}