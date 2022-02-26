using System;
using System.Collections.Generic;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {

        readonly List<object> animalList;

        public EmydexFarmSystem()
        {
            this.animalList = new List<object>();
        }
        //TEST 1
        public void Enter(object animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities

            this.animalList.Add(animal);
            Console.WriteLine("{0} has entered the Emydex farm", animal.GetType().Name);
        }
     
        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            Console.WriteLine("There are no animals in the farm");
        }

        //TEST 3
        public void MilkAnimals()
        {
            Console.WriteLine("Cannot identify the farm animals which can be milked");
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
           Console.WriteLine("There are still animals in the farm, farm is not free");
        }
    }
}