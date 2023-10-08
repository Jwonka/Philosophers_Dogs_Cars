//Author: Josh Werlein
//Purpose: Create an application with 3 classes of Philospher Dog and Car
//Date: 9/20/2023

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhilosopherDogCar_List
{
    internal class Dog
    {
        //Define Class level Variables
        private string mBreed;
        private string mWeight;
        private string mColor;

        public string Breed
        { get { return mBreed; } set { mBreed = value; } }
        public string Weight
        { get { return mWeight; } set { mWeight = value; } }
        public string Color
        { get { return mColor; } set { mColor = value; } }

        //Default constructor
        public Dog()
        {
            mBreed = string.Empty;
            mWeight = string.Empty;
            mColor = string.Empty;
        }

        //Overload constructor
        public Dog(string Breed)
        {
            mBreed = Breed;
            mWeight = string.Empty;
            mColor = string.Empty;
        }

        //Method
        public string GetDogDescription()
        {
            return "The " + mColor + " dog is a " + mBreed + " that weighs " + mWeight + " pounds." ;
        }
    }
}
